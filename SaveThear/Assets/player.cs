using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private BoxCollider2D boxCollider;

    private Vector3 moveDelta;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }
    
    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
    
        // reset movedelta
        moveDelta = new Vector3(x,y,0);

        //Swap sprite direction
        /* if(moveDelta.x > 0)
            transform.localScale = Vector3.one;
        else if(moveDelta.x < 0)
            transform.localScale = new Vector3(-1, 1 ,1); */


        //move
        transform.Translate(moveDelta * Time.deltaTime);
    }
}
