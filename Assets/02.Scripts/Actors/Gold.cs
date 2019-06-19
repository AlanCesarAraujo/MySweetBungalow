using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour {

	private int coins;

	// Use this for initialization
	void Start () {
		coins = 10;
	}

	//Gets & Sets
	public int getCoins(){
		return coins;
	}

	public void setCoins(int coins){
		this.coins = coins;
	}
}
