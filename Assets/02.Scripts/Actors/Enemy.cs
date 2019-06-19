using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character {

	// Use this for initialization
	void Start () {
		lifeTotal = 6;
		atk = 1;
		def = 1;
		level = 1;

		Debug.Log("Enemy: I will defeat you!");
		Debug.Log("LT = "+lifeTotal+", Atk = "+atk+", Def = "+def+", Lvl = "+level+".");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
