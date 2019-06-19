using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character {

	private int exp;

	// Use this for initialization
	void Start () {		
		lifeTotal = 10;
		atk = 3;
		def = 2;
		level = 1;
		exp = 0;

		Debug.Log("Hero: I am ready for the fight!");
		Debug.Log("LT = "+lifeTotal+", Atk = "+atk+", Def = "+def+", Lvl = "+level+", Exp = "+exp+".");
	}
	
	// Update is called once per frame
	void Update () {}

	//Methods
	public void takeItem(GameObject item){
		Debug.Log("Hope you like it ;)");
	}

	public void die(){
		Debug.Log("You're dead... But can return!");
	}

	//Gets e Sets
	public int getExp(){
		return exp;
	}

	public void setExp(int exp){
		this.exp = exp;
	}
}
