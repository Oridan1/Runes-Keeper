using UnityEngine;
using System.Collections;

public class Sonido : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void play() 
    {
        GetComponent<AudioSource>().Play();
    }

}
