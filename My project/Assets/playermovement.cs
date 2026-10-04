using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
   public float movespeed;

   public float jumpHeight;
   public KeyCode jumpKey;
   public keyCode L;
   public keyCode R;
   public float groundCheckRadius;
   public LayerMask groundLayer;
   public bool isGrounded;
   public Transform groundCheck;
    void Start()
    {
        
    }

   
    void Update()
    {
        if(Input.GetKeyDown(Spacebar))
        {
            Jump();
        }
         if(Input.GetKey(L))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
           if(Input.GetKey(R))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
    }
    void jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
    }

    if (Input.GetKey(L)) 
{
    GetComponent<Rigidbody2D>().velocity =new Vector2(-moveSpeed,GetComponent<Rigidbody2D>().velocity.y);


    if (GetComponent<SpriteRenderer>() != null)
    {
        GetComponent<SpriteRenderer>().flipX = true;
    }
}

if (Input.GetKey(R)) 
{
    GetComponent<Rigidbody2D>().velocity =new Vector2(moveSpeed,GetComponent<Rigidbody2D>().velocity.y);


    if (GetComponent<SpriteRenderer>() != null)
    {
        GetComponent<SpriteRenderer>().flipX = false;
    }
}

}
