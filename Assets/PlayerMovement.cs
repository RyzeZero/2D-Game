using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    public float jumpForce;

    private Rigidbody2D rig;

    private bool isJumping;

     void Start()
    {
        rig = GetComponent<Rigidbody2D>(); 
    }
    // Update is called once per frame
    void Update()
    {
        rig.velocity = new Vector2(playerSpeed, rig.velocity.y);
        
        if (Input.GetMouseButtonDown(0) && !isJumping)
        {
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

            isJumping = true;
        }
    }
        void OnCollisionEnter2D(Collision2D colisor)
    {
        if(colisor.gameObject.layer == 6)
        {
            isJumping = false;
        }
    }
}
