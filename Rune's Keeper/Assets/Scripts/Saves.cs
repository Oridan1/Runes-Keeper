using UnityEngine;
using System.Collections;
using System;// libreria para guardado  de datos 
using System.Runtime.Serialization.Formatters.Binary; //  lib para guardado de datos
using System.IO;


public class Saves : MonoBehaviour
{

    public Player player;
    public Enemy enemy;

    public static Saves control;

    // Use this for initialization
    void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else
        {
            if (control != this)
            {
                Destroy(gameObject);
            }

        }
    }

    public void Start()
    {
        Saves.control.Load();
    }

    public void Update()
    {
        Save();
    }



    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        PlayerData data = new PlayerData(); // crea un nuevo player data 
        data.nivel = player.level; // al crear uno  nuevo  lo  sobreescribe con los datos deseados 
        data.vida = player.health.Maxval;
        data.maxexp = player.exp.Maxval;
        data.exp = player.exp.CurrentVal;
        data.enemigo = enemy.health.Maxval;
        data.pociones = player.Pociones;
        bf.Serialize(file, data);
        file.Close();
    }


    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);

            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();
            player.level = data.nivel;
            player.health.Maxval = data.vida;
            player.health.CurrentVal = player.health.Maxval;
            player.exp.Maxval = data.maxexp;
            player.exp.CurrentVal = data.exp;
            enemy.health.Maxval = data.enemigo;
            enemy.health.CurrentVal = enemy.health.Maxval;
            player.Pociones = data.pociones;
        }

    }

}
[Serializable]
class PlayerData
{
    public int nivel;
    public float vida;
    public float maxexp;
    public float exp;
    public float enemigo;
    public int pociones;

}