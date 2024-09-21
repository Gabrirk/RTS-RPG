using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman_Attack03 : MonoBehaviour
{
    private int damage = 4;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<BaseEnemy>() != null)
        {
            BaseEnemy health = collision.GetComponent<BaseEnemy>();
            health.TakeDamage(damage);
        }
    }
}
