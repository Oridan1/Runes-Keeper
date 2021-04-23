using UnityEngine;
using System.Collections;

public class Skills : MonoBehaviour {
	public int fire;
	public int water;
	public int air;
	public int earth;
	[SerializeField]
	private Stat health;
	private CreateGame runas;
	private void Awake ()
	{
		health.Initialize();

	}
	// Use this for initialization
	void Start () {
		
		if (fire == 3) {
			health.CurrentVal -= 10;
			fire = 0;
		}
		if (water == 3) {
			health.CurrentVal -= 10;
			water = 0;
		}
		if (air == 3) {
			health.CurrentVal -= 10;
			air = 0;
		}
		if (earth == 3) {
			health.CurrentVal -= 10;
			earth = 0;
		}

	}
	
	// Update is called once per frame
	void Update () {
		fire = runas.fuego;
		water = runas.agua;
		air = runas.aire;
		earth = runas.tierra;
	}
}
