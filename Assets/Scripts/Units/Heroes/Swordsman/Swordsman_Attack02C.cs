using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman_Attack02C : MonoBehaviour
{
    private int damage = 2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<BaseEnemy>() != null)
        {
            BaseEnemy health = collision.GetComponent<BaseEnemy>();
            health.TakeDamage(damage);
        }
    }
}
