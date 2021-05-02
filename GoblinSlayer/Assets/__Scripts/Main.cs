using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject goblinEnemy;
    public GameObject goblinEnemy2;
    int selectedCharacter;

    void Start()
    {

    //selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");

    Instantiate(goblinEnemy, new Vector3(15,0,20), Quaternion.identity);
    Instantiate(goblinEnemy, new Vector3(10,0,24), Quaternion.identity);
    Instantiate(goblinEnemy, new Vector3(22,0,24), Quaternion.identity);
    Instantiate(goblinEnemy, new Vector3(33,0,21), Quaternion.identity);
    Instantiate(goblinEnemy, new Vector3(20,0,15), Quaternion.identity);
    Instantiate(goblinEnemy, new Vector3(0,0,5), Quaternion.identity);
    Instantiate(goblinEnemy, new Vector3(45,0,5), Quaternion.identity);
    Instantiate(goblinEnemy, new Vector3(38,0,-1), Quaternion.identity);
    Instantiate(goblinEnemy, new Vector3(35,0,10), Quaternion.identity);
    Instantiate(goblinEnemy, new Vector3(44,0,-5), Quaternion.identity);


    }

}
