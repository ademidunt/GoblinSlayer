using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript: MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    // private void Start()
    // {
    //     rb = GetComponent<Rigidbody>();
    // }

 
    // void FixedUpdate()
    // {
    //     float moveHorizontal = Input.GetAxis("Horizontal");
    //     float moveVertical = Input.GetAxis("Vertical");
    //     Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
    //     rb.AddForce(movement * speed);
    // }

    void update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0);
    } 
}