using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    
    public GameObject MainMenuUI; 
    public GameObject HelpUI;
    
    
    public void Play(){

        SceneManager.LoadScene("openingScene");    

        }
    
    public void Help(){

        MainMenuUI.SetActive(false);
        HelpUI.SetActive(true);

        }

     public void Back(){

        MainMenuUI.SetActive(true);
        HelpUI.SetActive(false);

        }

}
