using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSelectionPanel : BasePanel
{
    public Button btnGame1;

    private void Start()
    {
        btnGame1.onClick.AddListener(delegate
        {
            Hide();
            UIManger.Instance.ShowPanel<Game1>();
        });
    }
}
