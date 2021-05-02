using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Animator animator;
    int isWalkingHash;
    int isBackwardHash;
    int isJumpingHash;
    int isRunningHash;



    //Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isBackwardHash = Animator.StringToHash("isBackward");
        isJumpingHash = Animator.StringToHash("isJumping");
        isRunningHash = Animator.StringToHash("isRunning");


    }

    //Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool("isWalking");
        bool forwardPressed = Input.GetKey(KeyCode.UpArrow);
        bool isBackward = animator.GetBool("isBackward");
        bool backwardPressed = Input.GetKey(KeyCode.DownArrow);
        bool isJumping = animator.GetBool("isJumping");
        bool jumpingPressed = Input.GetKey(KeyCode.Space);
        bool isRunning = animator.GetBool("isRunning");
        bool runningPressed = Input.GetKey(KeyCode.X);
        //bool runForwardPressed = ;
        
        


        //if player pressed forward key (or up arrow)
        if(forwardPressed)
        {
            animator.SetBool(isWalkingHash, true);
        }
        if(!forwardPressed)
        {
            animator.SetBool(isWalkingHash, false);
        }

        //if player pressed backward key (or down arrow)
        if(backwardPressed)
        {
            animator.SetBool(isBackwardHash, true);
        }
        if(!backwardPressed)
        {
            animator.SetBool(isBackwardHash, false);
        }

        //if player pressed the space key 
        if(jumpingPressed)
        {
            animator.SetBool(isJumpingHash, true);
        }
        if(!jumpingPressed)
        {
            animator.SetBool(isJumpingHash, false);
        }

        //if player pressed the x key and the up arrow at the same time
        if(runningPressed)
        {
            animator.SetBool(isRunningHash, true);
        }
        if(!runningPressed)
        {
            animator.SetBool(isRunningHash, false);
        }
    }
}
