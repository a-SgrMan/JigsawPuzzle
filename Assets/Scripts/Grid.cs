using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using LastZero.EventSystem;
using LastZero.Utility;

public class Grid : MonoBehaviour
{
    private RawImage image;
    private Grid follow;
    private Game game;

    private void Awake()
    {
        image = GetComponent<RawImage>();
    }

    private void Start()
    {
        gameObject.AddBeginDragEvent(delegate
        {
            follow = Instantiate(this, transform.root, transform);
            follow.SetRaycastTarget(false);
        });
        gameObject.AddDragEvent(delegate
        {
            follow.transform.position = Input.mousePosition;
        });
        gameObject.AddEndDragEvent(delegate
        {
            Grid target = MouseOverController.GetOverUI(transform.root.gameObject).GetComponent<Grid>();
            Destroy(follow.gameObject);
            if (target == null || target == this)
            {
                return;
            }

            int indexSelf = transform.GetSiblingIndex(),
                indexTarget = target.transform.GetSiblingIndex();

            if (indexSelf < indexTarget)
            {
                transform.SetSiblingIndex(indexTarget);
                target.transform.SetSiblingIndex(indexSelf);
            }
            else
            {
                target.transform.SetSiblingIndex(indexSelf);
                transform.SetSiblingIndex(indexTarget);
            }

            game.DoStep();
        });
    }

    /// <summary>
    /// 设置当前Grid的信息
    /// </summary>
    /// <param name="size">n*n</param>
    /// <param name="id">Grid的ID</param>
    public void SetInf(Game game, int size, Vector2 id)
    {
        this.game = game;
        float width = 1f / size;

        gameObject.name = $"Grid_{id.x}_{id.y}";
        image.uvRect = new Rect(
            (id.x - 1) * width,
            (id.y - 1) * width,
            width,
            width
        );
    }

    /// <summary>
    /// 设置射线为不检测，用来防止检测鼠标下UI出现问题
    /// </summary>
    /// <param name="raycastTarget"></param>
    public void SetRaycastTarget(bool raycastTarget)
    {
        image.raycastTarget = raycastTarget;
    }
}
