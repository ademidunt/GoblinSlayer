using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public bool boosted = false;
    public bool check = false;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health; 
        slider.value = health; 
        fill.color = gradient.Evaluate(1f);

    }

    public void SetHealth(int health)
    {

        if(!boosted){
            slider.value = health;
            fill.color = gradient.Evaluate(slider.normalizedValue);
 
            
        }    
        
        
        
        if (GameObject.Find("Player").GetComponent<PlayerController>().currentHealth == 16 && !boosted ){
          boosted = true;
             SetMaxHealth(50);
             GameObject.Find("Player").GetComponent<PlayerController>().currentHealth = 50;
            
                 
        } 
       

        if(boosted){
            check = true;
            slider.value = health;
            fill.color = gradient.Evaluate(slider.normalizedValue);

        }

       
    }

    
}
