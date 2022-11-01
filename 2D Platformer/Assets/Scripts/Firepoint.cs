using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firepoint : MonoBehaviour
{
     private bool isFacingRight = true;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(!isFacingRight)
            {
             FlipFirePoint();
            }
            else if(isFacingRight)
            {
             BacktoRight();
            }
        }
    }

    void FlipFirePoint()
    {
        isFacingRight = true;
        transform.eulerAngles = new Vector3(0,0,0);
    }

    void BacktoRight()
    {
        isFacingRight = false;
        transform.eulerAngles = new Vector3(0,-180,0); 
    }
}
