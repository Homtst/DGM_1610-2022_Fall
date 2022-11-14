using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    private PlayerHealth health;
    public int damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        health = GameObject.Find("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        health.TakeDamage(damage);
        Debug.Log("Player Takes "+ damage +" points of damage");
    }
}
