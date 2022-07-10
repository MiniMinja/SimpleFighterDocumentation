using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hor_CM_Handler : MonoBehaviour
{
    public float movePower;

    InputLookup lookup;
    Rigidbody2D rb;

    void Start()
    {
        lookup = GetComponent<InputLookup>();

        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if(lookup.Lookup(InputLookup.LEFT)){
            Move(-1);
        }
        if(lookup.Lookup(InputLookup.RIGHT)){
            Move(1);
        }
    }

    public void Move(int dir){
        rb.AddForce(Vector2.right * dir * movePower);
    }
}
