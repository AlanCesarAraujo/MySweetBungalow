using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	private String name; 
	private String type;
	private int rarity;//1=common, 2=rare, 3=epic, 4=legendary. 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Methods
	public void artsNCrafts(String name, String type, int rarity){
		this.name = name;
		this.type = type;
		this.rarity = rarity;

		Debug.Log("Oooh! A new treasure!");
	}

	//Gets & Sets
	//Name
	public String getName(){
		return name;
	}

	public void setName(String name){
		this.name = name;
	}

	//Type
	public String getType(){
		return type;
	}

	public void setType(String type){
		this.type = type;
	}

	//Rarity
	public int getRarity(){
		return rarity;
	}

	public void setRarity(int rarity){
		this.rarity = rarity;
	}
}
