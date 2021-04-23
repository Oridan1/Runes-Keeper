using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public Enemy enemy;
    public Text runastxt;
    public Text exptxt;
    public Text pociones;
    public Text niveltxt;  
	public int fire;
	public int water;
	public int air;
	public int earth;
    public Text vida;
	[SerializeField]
    public Stat health;
    public Stat exp;
    public int level = 1;
    public float countdown = 5.0f;
    public int Pociones = 0;	  
	private void Awake()
    {
        health.Initialize();
	}
	// Update is called once per frame
	void Update () 
    {
        countdown -= Time.deltaTime;		
        vida.text = health.CurrentVal + "/" + health.Maxval;
        exptxt.text = exp.CurrentVal + "/" + exp.Maxval;
        pociones.text = Pociones.ToString();
        runastxt.text = "AGUA:  " + water + "  AIRE:  " + air + "  FUEGO:  " + fire + "  TIERRA:  " + earth;
        niveltxt.text = level.ToString();
        if (countdown <= 0.0f)
        {
            health.CurrentVal -= 5;
            countdown = 5.0f;
        }
        if (health.CurrentVal <= 0)
        {
            muerte();
        }
        if (health.CurrentVal > health.Maxval)
        {
            health.CurrentVal = health.Maxval;
        }
	}

    public void muerte()
    {
        water = 0;
        air = 0;
        fire = 0;
        earth = 0;        
        health.CurrentVal = health.Maxval;
        enemy.health.CurrentVal = enemy.health.Maxval;        
    }
}
