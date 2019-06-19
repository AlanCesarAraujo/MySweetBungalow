using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dungeon : MonoBehaviour {

	private int number;
	private int numRooms;
	public GameObject[] rooms;

	// Use this for initialization
	void Start () {
		number = 1;
		numRooms = Random.Range(5,10);
		Debug.Log("New Dungeon. Number of Rooms: "+numRooms+".");

		for(int i = 0; i < numRooms; i++){

			rooms[i].SetActive(true);
			Room roomScript = rooms[i].GetComponent<Room>();
			roomScript.whatIsInside = Random.Range(0,2);

			Debug.Log("Room nº "+(i+1)+".");

			if(i == numRooms - 1){
				roomScript.whatIsInside = 2;
			}

			if(roomScript.whatIsInside == 0){
				
				roomScript.item.SetActive(true);
				Debug.Log("An Item...");

			}else if(roomScript.whatIsInside == 1){
				
				roomScript.enemy.SetActive(true);
				Debug.Log("An enemy!!!");

			}if(roomScript.whatIsInside == 2){

				roomScript.boss.SetActive(true);
				Debug.Log("A BOSS!!!");
			
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Gets & Sets
	//Number
	public int getNumber(){
		return number;
	}

	public void setNumber(int number){
		this.number = number;
	}

	//Number of Rooms
	public int getNumRooms(){
		return numRooms;
	}

	public void setNumRooms(int numRooms){
		this.numRooms = numRooms;
	}
}
