using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class LockController : MonoBehaviour
{
 
   
   public static bool ChestMenuOpen = false;
   public GameObject ChestMenuUI;
   public GameObject correctText;
   public GameObject incorrectText;
   public GameObject RElf;
   public GameObject CElf;
   public GameObject winText;
   public GameObject instructionText;

   float proxy = 3f;
   public Transform Character; 
   public Transform Lock;
   


    public void Exit(){

            ChestMenuUI.SetActive(false);
            Time.timeScale = 1f; 
            ChestMenuOpen = false;

        }
    
    public void Open(){

            ChestMenuUI.SetActive(true);
            instructionText.SetActive(false);
            Time.timeScale = 0f; 
            ChestMenuOpen = true;
            instructionText.SetActive(false);



        }

    public void OnCorrect(){

        correctText.SetActive(true); 
        incorrectText.SetActive(false);
        RElf.SetActive(true);
        CElf.SetActive(false);
        //GameObject.Find("Player").GetComponent<PlayerController1>().keyprogress += 50;
        winText.SetActive(true);

    }
    public void OnInCorrect(){

       
        incorrectText.SetActive(true); 
        correctText.SetActive(false);

    }


    void Update()
    {

    float distance = Vector3.Distance(Lock.position, Character.position);

    if((distance<=proxy) && Input.GetKeyDown(KeyCode.Escape))
        {
            Open();

        }


    }
}
