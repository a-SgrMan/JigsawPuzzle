using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManger : MonoBehaviour
{
    public static UIManger Instance;

    public List<BasePanel> panels = new List<BasePanel>();

    private void Awake()
    {
        Instance = this;

        panels.AddRange(GetComponentsInChildren<BasePanel>());
    }

    private void Start()
    {
        for (int i = 1; i < panels.Count; i++)
        {
            panels[i].Hide();
        }
    }

    public T ShowPanel<T>() where T : BasePanel
    {
        T panel = panels.Find(p => p is T) as T;
        panel.Show();

        return panel;
    }

    public T HidePanel<T>() where T : BasePanel
    {
        T panel = panels.Find(p => p is T) as T;
        panel.Hide();

        return panel;
    }
}
