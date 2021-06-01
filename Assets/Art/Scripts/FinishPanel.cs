using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishPanel : BasePanel
{
    public Button btnAgain;

    private void Start()
    {
        btnAgain.onClick.AddListener(delegate
        {
            Hide();
            UIManger.Instance.HidePanel<Game>();
            UIManger.Instance.ShowPanel<HomePagePanel>();
        });
    }
}
