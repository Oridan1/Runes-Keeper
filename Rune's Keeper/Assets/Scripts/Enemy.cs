using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {
    [SerializeField]
    public Stat health;
    public Text vida;
    private void Awake()
    {
        health.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        vida.text = health.CurrentVal + "/" + health.Maxval;
    }
}
