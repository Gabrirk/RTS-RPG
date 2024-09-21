using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc_Attack02 : MonoBehaviour
{
    private int damage = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<BaseHero>() != null)
        {
            BaseHero health = collision.GetComponent<BaseHero>();
            health.TakeDamage(damage);
        }
    }
}
