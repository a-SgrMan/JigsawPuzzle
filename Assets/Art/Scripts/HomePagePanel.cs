using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomePagePanel : BasePanel
{
    public Button btnStart;

    private void Start()
    {
        btnStart.onClick.AddListener(delegate
        {
            Hide();
            UIManger.Instance.ShowPanel<GameSelectionPanel>();
        });
    }
}
