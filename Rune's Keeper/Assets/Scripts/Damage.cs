using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Damage : MonoBehaviour {
    public Player player;
    public Enemy enemy;    
    public void skill()
    {
        if (player.Pociones > 0 && player.health.CurrentVal < player.health.Maxval)
        {
            player.health.CurrentVal += 50;
            player.Pociones--;
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
            player.fire= 0;
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
    private void muerte()
    {
        if (enemy.health.CurrentVal <= 0)
        {
            enemy.health.Maxval += 20;
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
        player.exp.Maxval += 50;
        player.exp.CurrentVal = 0;
        player.health.Maxval += 20;
        player.health.CurrentVal = player.health.Maxval;
        player.Pociones++;
    }
}
