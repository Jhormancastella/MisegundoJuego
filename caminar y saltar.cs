using System.collections;
using System.collections.Generic;
using UnityEngine;

public class player : Monobehaviour
{
    public float speed;
    public float JumpForce;
    private Rigidbody2D Rigidbody2D;
    private float Horizontal; 

    private bool Grouded;
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Horizontal = input.GetAxisRaw("Horizontal");

        Debug.DrawRay(transform.position,vector3.down * 0.1f,color.red);//para que fucione ir a project seting physics 2D desactivar queries star in colliders
        if(physics2D.Raycaste(trasnform.position, vector3.down,0.1f))
        {
            Grouded = true;
        }
        else Grouded = false;

        if(Input.Getkeydown(keyCode.w)&& Grouded)
        {
            jump();
        }
    }
    private void jump()
    {
        Rigidbody2D.addForce(vector2.up*JumpForce);
    }
    private void FixedUpdate();
    {
        Rigidbody2D.velocity = new vector(Horizontal,Rigidbody2D.velocity.y);
    }
}