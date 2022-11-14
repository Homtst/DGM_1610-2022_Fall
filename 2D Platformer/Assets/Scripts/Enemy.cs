using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log(damage + " Damage Taken!");

        if(health <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        Destroy(gameObject);
        Debug.Log("Enemy has perished!");
    }
}
