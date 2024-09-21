using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class Knight_Attack02 : MonoBehaviour
{
    private int damage = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<BaseEnemy>() != null)
        {
            BaseEnemy health = collision.GetComponent<BaseEnemy>();
            health.TakeDamage(damage);
        }
    }
}
