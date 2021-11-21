using System;
using UnityEngine;
using Zork.Common;
using TMPro;

public class UnityOutputService : MonoBehaviour, IOutputService
{
    [SerializeField]
    private TextMeshProUGUI OutputText;

    public void Write(string value)
    {
        throw new System.NotImplementedException();
    }

    public void Write(object value)
    {
        Write(value.ToString());
    }

    public void WriteLine(string value)
    {
        OutputText.text = value;
    }

    public void WriteLine(object value)
    {
        WriteLine(value.ToString());
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    void Start()
    {

    }


    void Update()
    {

    }
}
