using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public int fire;
	public int water;
	public int air;
	public int earth;
	[SerializeField]
    private Stat health;
	private CreateGame runas;
	private void Awake()
    {
        health.Initialize();
	}
	// Update is called once per frame
	void Update () 
    {
		runas = GameObject.Find ("Main Camera").GetComponent<CreateGame> ();
		fire = runas.fuego;
		water = runas.agua;
		air = runas.aire;
		earth = runas.tierra;

		if (fire == 3) {
			health.CurrentVal -= 10;
			runas.fuego -= 3;
			fire -= 3;
		}
		if (water == 3) {
			health.CurrentVal -= 10;
			runas.agua -= 3;
			water -=3 ;
		}
		if (air == 3) {
			health.CurrentVal -= 10;
			runas.aire -= 3;
			air -= 3;
		}
		if (earth == 3) {
			health.CurrentVal -= 10;
			runas.tierra -= 3;
			earth -= 3;
		}
	}
}
