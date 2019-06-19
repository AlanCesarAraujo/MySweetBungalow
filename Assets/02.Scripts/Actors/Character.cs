using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

	protected String name;
	protected int atk;
	protected int def;
	protected int lifeTotal;
	protected int level;

	// Use this for initialization
	void Start () {
		atk = 0;
		def = 1;
		lifeTotal = 2;
		level = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Methods
	public void attack(GameObject defender){
		Debug.Log("Attaaack!!!");
	}

	public void deffense(GameObject attacker){
		Debug.Log("Shields Up!!!");
	}

	//Gets & Sets
	//Nome
	public String getName(){
		return name;
	}

	public void setName(String name){
		this.name = name;
	}

	//Attack
	public int getAtk(){
		return atk;
	}

	public void setAtk(int atk){
		this.atk = atk;
	}

	//Deffense
	public int getDef(){
		return def;
	}

	public void setDef(int def){
		this.def = def;
	}

	//Life Total
	public int getLifeTotal(){
		return lifeTotal;
	}

	public void setLifeTotal(int lifeTotal){
		this.lifeTotal = lifeTotal;
	}

	//Level
	public int getLevel(){
		return level;
	}

	public void setLevel(int level){
		this.level = level;
	}
}
