using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : BaseUnit
{
    public GameObject player;
    [SerializeField] protected float _moveSpeed = 4f;
    private float distance;

    protected Rigidbody2D _rb;

    protected Animator _animator;

    //Animation States
    protected const string IDLE = "Idle";
    protected const string WALK = "Walk";

    protected const string ATTACK01 = "Attack01";
    protected const string ATTACK02 = "Attack02";

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        currentHealth = maxHealth;
    }

    private void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        if(distance < 4)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, _moveSpeed * Time.deltaTime);
        }
    }

    private void HandleMovement()
    {

    }

    private void HandleAttack()
    {

    }
}
