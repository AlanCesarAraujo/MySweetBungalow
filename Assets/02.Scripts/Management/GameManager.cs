using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject player;
	public GameObject item;
	public GameObject enemy;
	public GameObject boss;

	private Player playerScript;
	private Item itemScript;
	private Enemy enemyScript;
	private Boss bossScript;

	// Use this for initialization
	void Start () {
		playerScript = player.GetComponent<Player>();
		itemScript = item.GetComponent<Item>();
		enemyScript = enemy.GetComponent<Enemy>();
		bossScript = boss.GetComponent<Boss>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		interaction();
	}

	//Methods
	//Combat
	public void interaction(){

		for(int i = 0; playerScript.getLifeTotal() > 0 
			&& enemyScript.getLifeTotal() > 0 
			|| bossScript.getLifeTotal() > 0; i++){
			Debug.Log("Interactions...");
		}

	}

	public void turn(GameObject target){
		
		if(target.tag == "Item"){
			
			playerScript.takeItem(target);
		
		}else if(target.tag == "Enemy"){

			playerScript.attack(target);

		}else if(target.tag == "Boss"){

			playerScript.attack(target);

		}
	}
}
