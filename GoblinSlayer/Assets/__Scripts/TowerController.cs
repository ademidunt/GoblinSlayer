using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TowerController : MonoBehaviour
{

   float proxy = 5f;
   public Transform character; 
   public Transform tower;
   public GameObject openText;
   public bool close;

   
    // Start is called before the first frame update
   void Start()
   {
        close = false;
   }

    // Update is called once per frame
   void Update()
    {

    float distance = Vector3.Distance(tower.position, character.position);

    if(distance<=proxy)
        {
        close = true;
        if(Input.GetKey(KeyCode.O)){
            if(Input.GetKey(KeyCode.P)){
                if(Input.GetKey(KeyCode.E)){
                    if(Input.GetKey(KeyCode.N)){
                        SceneManager.LoadScene("dungeon");
                    }
                }
            }

        }

        }


    }
}
