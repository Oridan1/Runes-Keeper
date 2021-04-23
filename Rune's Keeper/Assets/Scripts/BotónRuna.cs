using UnityEngine;
using System.Collections;

public class BotónRuna : MonoBehaviour {
    public Player player;
    public Enemy enemy;
    public GameObject obj;
	// Use this for initialization
    void Start()
    { 
    
    }       
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        if (obj.tag == "Agua")
        { 
            agua();
        }
        if (obj.tag == "Aire")
        {
            aire();
        }
        if (obj.tag == "Fuego")
        {
            fuego();
        }
        if (obj.tag == "Tierra")
        {
            tierra();
        }
        if (obj.tag == "Poción")
        {
            poción();
        }
        if (obj.tag == "Enemy")
        {
            enemy.health.CurrentVal =0;
            muerte();
        }
    }

    public void agua()
    {
        if (player.water > 2)
        {
            enemy.health.CurrentVal -= player.water * 5;
            player.water = 0;
            muerte();
        }
    }
    public void aire()
    {
        if (player.air > 2)
        {
            enemy.health.CurrentVal -= player.air * 5;
            player.air = 0;
            muerte();
        }
    }
    public void fuego()
    {
        if (player.fire > 2)
        {
            enemy.health.CurrentVal -= player.fire * 5;
            player.fire = 0;
            muerte();
        }
    }
    public void tierra()
    {
        if (player.earth > 2)
        {
            enemy.health.CurrentVal -= player.earth * 5;
            player.earth = 0;
            muerte();
        }
    }
    public void poción()
    {
        if (player.Pociones > 0 && player.health.CurrentVal < player.health.Maxval)
        {
            player.health.CurrentVal += 25;
            player.Pociones--;
        }
    }

    private void muerte()
    {
        if (enemy.health.CurrentVal <= 0)
        {
            enemy.health.Maxval += 10;
            enemy.health.CurrentVal = enemy.health.Maxval;
            player.exp.CurrentVal += 50;
            player.level++;          
            if (player.exp.CurrentVal >= player.exp.Maxval)
            {
                levear();
            }
        }
    }
    private void levear()
    {
        player.exp.Maxval += 20;
        player.exp.CurrentVal = 0;
        player.health.Maxval += 25;
        player.health.CurrentVal = player.health.Maxval;
        player.Pociones++;
    }
}
