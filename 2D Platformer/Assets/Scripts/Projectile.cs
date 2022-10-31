using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 30f;
    public int damage = 10;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        if(other.gameObject.CompareTag("Enemy"))
        {
            enemy.TakeDamage(damage);//Run the TakeDamage function and apply damage to the enemy
        }
        Destroy(gameObject); // Destroy Projectile
    }
}
