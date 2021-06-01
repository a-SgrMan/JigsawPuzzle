using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : BasePanel
{
    public int size = 10;
    public Grid gridPrefab;
    public Text textStep;

    private int step;
    private GridLayoutGroup gridLayoutGroup;
    private List<Grid> grids = new List<Grid>();

    private void Awake()
    {
        gridLayoutGroup = transform.Find("Grids").GetComponent<GridLayoutGroup>();
    }

    public void SetGame(int size)
    {
        this.size = size;
        textStep.text = $"步数：{step = 0}";
        
        Init();
        RandomList();
    }

    /// <summary>
    /// 初始化
    /// </summary>
    private void Init()
    {
        gridLayoutGroup.cellSize = Vector2.one * (1000 - 5 * (size - 1)) / size;
        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= size; j++)
            {
                if ((i - 1) * size + j > grids.Count)
                {
                    grids.Add(Instantiate(gridPrefab, gridLayoutGroup.transform));
                }
                else
                {
                    grids[i].gameObject.SetActive(true);
                }
                grids[(i - 1) * size + j - 1].SetInf(this, size, new Vector2(i, j));
            }
        }
        if (grids.Count > size * size)
        {
            for (int i = size * size; i < grids.Count; i++)
            {
                grids[i].gameObject.SetActive(false);
            }
        }
    }

    /// <summary>
    /// 随机位置
    /// </summary>
    public void RandomList()
    {
        for (int i = 0; i < grids.Count; i++)
        {
            grids[i].transform.SetSiblingIndex(Random.Range(0, size * size));
        }
    }

    /// <summary>
    /// 交换步骤处理
    /// </summary>
    public void DoStep()
    {
        textStep.text = $"步数：{++step}";

        for (int i = 0; i < grids.Count; i++)
        {
            if (grids[i].transform.GetSiblingIndex() != i)
            {
                return;
            }
        }

        UIManger.Instance.ShowPanel<FinishPanel>();
    }
}
