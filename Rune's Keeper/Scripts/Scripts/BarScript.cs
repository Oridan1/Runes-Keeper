using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarScript : MonoBehaviour {
    [SerializeField]
    private float fillAmount;
    [SerializeField] 
    private Image content;
    public float MaxValue { get; set; }

    public float Value
    {
        set 
        {
            fillAmount = Map(value,MaxValue);
        }
    }

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
       
        HandleBar();
	}

    private void HandleBar()
    {
        if (fillAmount != content.fillAmount)
        {
            content.fillAmount = fillAmount;
        }
    }

    private float Map(float value, float inMax)
    {
        return value / inMax;
    }
}
