using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoblinEnemy : Enemy
{
    public int enemyHealth;
    public Transform Player;


    float moveSpeed = 0.5f;
    float range = 30f;
    float rotationSpeed = 3f;
    float stop = 0;

    public float enemyCooldown = 1;
    public int damage = 1;
    public float protectTime = 10f;

    public Transform myTransform;
    
    //declare private variables
    private bool playerInRange = false;
    private bool canAttack = true;


    void Awake()
    {

        Player = GameObject.FindWithTag("Player").transform;//target player1
        myTransform = transform; //cache transform data for easy access
    }

    void Start()
    {
        enemyHealth = 1;

    }



    void Update()
    {
        
        float distance = Vector3.Distance(myTransform.position, Player.position);

        if(distance<=range)
        {
            //look
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(Player.position-myTransform.position), rotationSpeed*Time.deltaTime);

            //move
            if(distance>stop)
            {
                myTransform.position+= myTransform.forward * moveSpeed * Time.deltaTime;
            }
        }
        if(GameObject.Find("Player").GetComponent<PlayerController1>().protect == true){
        StartCoroutine(MyCoroutine());
        }
  
        else if (playerInRange && canAttack)
        {
            if(GameObject.Find("Player").GetComponent<PlayerController1>().protect == false){
                GameObject.Find("Player").GetComponent<PlayerController1>().currentHealth -= damage;
                StartCoroutine(AttackCooldown());
                if(GameObject.Find("Player").GetComponent<PlayerController1>().currentHealth == 0)
                {
                 Invoke("Restart", 2); //restart the scene when the player's health is zero
                }
            }
        }

    }

    void OnTriggerEnter(Collider coll)
    {
         if(coll.gameObject.CompareTag("Player"))
          {
             playerInRange = true;
         
            if(GameObject.Find("Player").GetComponent<PlayerController1>().fight == true)
            {
            if(enemyHealth > 0)
            {
                enemyHealth -= damage;
                
            }
            if(enemyHealth <= 0)
            {
                Destroy(gameObject); 
            }
            }
          }

        
        if(coll.gameObject.CompareTag("Sword") && (GameObject.Find("Player").GetComponent<PlayerController1>().swing == true))
            {
                if(enemyHealth > 0)
                {
                    enemyHealth -= damage;
                    GameObject.Find("Player").GetComponent<PlayerController1>().killCount += 1 ;
                }
                if(enemyHealth <= 0)
                {
                    Destroy(gameObject);
                }
            }
        }

    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

    IEnumerator AttackCooldown()
     {
        canAttack = false;
        yield return new WaitForSeconds(enemyCooldown);
        canAttack = true;
     }
    IEnumerator MyCoroutine()
    {
        GameObject.Find("Player").GetComponent<PlayerController1>().protect = true; 
        yield return new WaitForSeconds(10f); //wait 10 seconds
        GameObject.Find("Player").GetComponent<PlayerController1>().protect = false;
    }
   

    public void Restart()
    {
        SceneManager.LoadScene("openingScene");
    }

}
