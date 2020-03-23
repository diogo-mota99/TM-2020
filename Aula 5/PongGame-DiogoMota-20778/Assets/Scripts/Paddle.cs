using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
   public float speed;
   public Rigidbody2D rb;

   private Vector3 startPosition;

   private float movement;

   void Start()
   {
       startPosition = transform.position; //Store first position
   }

   //Update is called once per frame
   void Update()
   {
       //Access this Vertical Input in Edit > Input > Axes > Vertical

       movement = Input.GetAxisRaw("Vertical"); //Default by Unity 'W' and 'S' keys and other properties; Returns the value of the virtual axis, in the range of -1...1
       rb.velocity = new Vector2(rb.velocity.x, movement * speed); //Set velocity of Paddle
   }

   public void Reset()
   {
       rb.velocity = Vector2.zero;          //Reset velocity
       transform.position = startPosition;   //Reset position to the initial one
   }
}
