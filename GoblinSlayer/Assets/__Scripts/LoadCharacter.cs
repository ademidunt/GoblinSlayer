using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadCharacter : MonoBehaviour
{
	//public GameObject[] characterPrefabs;
	public GameObject[] enemyPrefabs;
	//public Transform spawnPoint;
	//public GameObject goblinEnemy;
	//int selectedEnemy; 
	int selectedCharacter;
	//GameObject playerPrefab;
	GameObject enemyPrefab;
	//GameObject clone;
	public GameObject player;
	public GameObject player2;
	public GameObject enemy1;
	public GameObject enemy2;

	GameObject goblin1;
	GameObject goblin2;
	GameObject goblin3;
	GameObject goblin4;
	GameObject goblin5;
	


	void Start()
	{

		selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");

		if( selectedCharacter == 0){
			player.SetActive(true);
			player2.SetActive(false);
			//enemy1.SetActive(true);
			//enemy2.SetActive(false);


		}
		else if(selectedCharacter == 1){
			
			player.SetActive(false);
			player2.SetActive(true);
			//enemy1.SetActive(false);
			//enemy2.SetActive(true);
		}
		
		

	}
}
