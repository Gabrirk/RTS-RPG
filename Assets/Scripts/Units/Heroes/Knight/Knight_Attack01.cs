using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight_Attack01 : MonoBehaviour
{

    private int damage = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<BaseEnemy>() != null)
        {
            BaseEnemy health = collision.GetComponent<BaseEnemy>();
            health.TakeDamage(damage);
        }
    }

}
