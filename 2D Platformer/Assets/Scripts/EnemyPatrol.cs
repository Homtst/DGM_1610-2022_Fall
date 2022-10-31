using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed; // How fast the enemy moves
    public float rayDistance; // how far the ray extends

    private bool isMovingRight = true; //Is the enemy moving right

    public Transform groundDetection; // Is the enemy touching the ground

    // Update is called once per frame
    void Update()
    {
       // Moove the enemy to the right
       transform.Translate(Vector2.right * speed * Time.deltaTime);

       RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, rayDistance);

       if(groundInfo.collider == false)
       {
        if(isMovingRight == true)
        {
            // Flip Enemy at edge to move left
            transform.eulerAngles = new Vector3(0,-180,0);
            isMovingRight = false;
        }
        else
        {
            //Flip Enemy at edge to move right
            transform.eulerAngles = new Vector3(0,0,0);
            isMovingRight = true;
        }
       }
    }
}
