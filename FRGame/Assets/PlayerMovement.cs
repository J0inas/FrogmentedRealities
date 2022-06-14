using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement; //Vector2 = stores x and y

    // Update is called once per frame
    void Update()
    {
        //Input

        movement.x = Input.GetAxisRaw("Horizontal"); //to input certain dimension, left = -1, right = 1, idle = 0
        movement.y = Input.GetAxisRaw("Vertical");
        movement = movement.normalized;//to avoid faster diagonal movement

        animator.SetFloat("Horizontal", movement.x);//movement.x gibt -1, 0 oder 1 aus -> Parameter Horizontal ändert sich zu diesem
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);//movement.sqrMagnitude beschreibt Länge des Movementvektors = Speed

    }

    void FixedUpdate()
    {
        //Movement

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); //Movement auf rb angewendet, Speed miteinberechnet,
                                                                                   //Time.fixedDeltaTime für konstanten Speed
        

    }

}
