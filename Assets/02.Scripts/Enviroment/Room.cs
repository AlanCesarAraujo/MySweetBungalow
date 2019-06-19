using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : Dungeon {

	public int whatIsInside;

	public GameObject item;
	public GameObject enemy;
	public GameObject boss;

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {

	}

	//Gets & Sets
	//What is Inside
	public int getWhatIsInside(){
		return whatIsInside;
	}

	public void getWhatIsInside(int whatIsInside){
		this.whatIsInside = whatIsInside;
	}
}
