using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomePagePanel : BasePanel
{
    public Dropdown dropdown;
    public Button btnStart;

    private readonly List<int> sizes = new List<int>() { 2, 3, 5, 10 };

    private void Start()
    {
        btnStart.onClick.AddListener(delegate
        {
            Hide();
            UIManger.Instance.ShowPanel<Game>().SetGame(sizes[dropdown.value]);
        });
    }
}
