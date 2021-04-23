using UnityEngine;
using System.Collections;

public class Aspecto : MonoBehaviour {
public  float camera1 =200 ;
public float camera2 = 300;


    public void Update()
    {

        Debug.Log(Camera.main.aspect);
        Camera.main.aspect = camera1 / camera2;

    }
}
