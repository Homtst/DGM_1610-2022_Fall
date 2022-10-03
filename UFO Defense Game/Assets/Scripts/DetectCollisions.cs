using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject); // Destroy the other game object it hits
        Destroy(gameObject); // Destroy this game object
    }
}
