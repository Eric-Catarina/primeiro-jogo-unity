using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuloMelhorado : MonoBehaviour
{
    private float fallMultiplier = 2.5f;
    private float lowJumpMultiplier = 2f;

    Rigidbody2D rb;

    void Awake(){
        rb=GetComponent<Rigidbody2D>();
    }

    void Update(){
        if (rb.velocity.y <0){
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier-1) * Time.deltaTime;
        }
        else if ( rb.velocity.y >0 && !Input.GetButton("Jump")){
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier-1) * Time.deltaTime;
        }

    }
}
