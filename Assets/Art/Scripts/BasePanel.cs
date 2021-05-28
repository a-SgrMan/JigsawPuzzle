using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePanel : MonoBehaviour
{
    /// <summary>
    /// 显示面板
    /// </summary>
    public void Show()
    {
        gameObject.SetActive(true);
    }

    /// <summary>
    /// 隐藏面板
    /// </summary>
    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
