using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController2 : PlayerController
{


    

    public override void Fight()
    {

        bool isFighting = animator.GetBool("isFighting");
        bool fightingPressed = Input.GetKey(KeyCode.B);
        
        //if player pressed B key 
        if(fightingPressed)
        {
            animator.SetBool(isFightingHash, true);
            fight = true;

        }
        if(!fightingPressed)
        {
            animator.SetBool(isFightingHash, false);
            fight = false;
        }
    }
    public override void Swing()
    {
        bool isSwinging = animator.GetBool("isSwinging");
        bool swingingPressed = Input.GetKey(KeyCode.Space);        


        //if player pressed Space key 
        if(swingingPressed)
        {
            animator.SetBool(isSwingingHash, true);
            swing = true;
        }
        if(!swingingPressed)
        {
            animator.SetBool(isSwingingHash, false);
            swing = false;
        }
    }

   

}
