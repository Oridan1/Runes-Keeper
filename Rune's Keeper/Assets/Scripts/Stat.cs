using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class Stat
{
    [SerializeField]
    private BarScript bar;
    [SerializeField]
    private float maxVal;
    [SerializeField]
    private float currentVal;
    public float CurrentVal
    {
        get
        {
            return currentVal;
        }
        set
        {           
            this.currentVal = value;
            bar.Value = currentVal;
        }
    }
    public float Maxval
    {
        get
        {
            return maxVal;
        }
        set
        {
            this.maxVal = value;
            bar.MaxValue = maxVal;
        }
    }
    public void Initialize()
    {
        this.Maxval = maxVal;
        this.CurrentVal = currentVal;

    }

}
