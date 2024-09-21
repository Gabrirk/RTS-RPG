using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR.Haptics;

public class BaseHero : BaseUnit
{
    protected Vector2 _movement;
    [SerializeField] protected float _moveSpeed = 5f;

    protected Rigidbody2D _rb;

    protected Animator _animator;

    //Animation States
    protected const string IDLE = "Idle";
    protected const string WALK = "Walk";

    protected const string ATTACK01 = "Attack01";
    protected const string ATTACK02 = "Attack02";
    protected const string ATTACK03 = "Attack03";

    /*
    const string DEATH = "Death";
    const string HURT = "Hurt";
    const string BLOCK = "Block";
    const string ATTACK02 = "Attack02";
    const string ATTACK03 = "Attack03";
    */

    protected bool _isFacingRight = true;
    protected string currentState;
    protected bool _isAttacking = false;
    protected bool _canMove = true;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();

    }

    private void Update()
    {
        HandleMovement();
        HandleAttack();
    }

    private void HandleMovement()
    {
        if (_canMove && !_isAttacking)
        {
            _movement.Set(InputManager.Movement.x, InputManager.Movement.y);
            _rb.velocity = _movement * _moveSpeed;

            if (_movement != Vector2.zero) // Movement
            {
                if (_movement.x > 0 && !_isFacingRight)
                {
                    FlipCharacter();
                }
                else if (_movement.x < 0 && _isFacingRight)
                {
                    FlipCharacter();
                }

                ChangeAnimationState(WALK);
            }
            else // Idle
            {
                ChangeAnimationState(IDLE);
            }
        }
    }


    protected virtual void HandleAttack()
    {
        if (InputManager.Attack01.triggered && !_isAttacking)
        {
            _canMove = false;
            _isAttacking = true;
            _rb.velocity = Vector2.zero;
            ChangeAnimationState(ATTACK01);
        }
        if (InputManager.Attack02.triggered && !_isAttacking)
        {
            _canMove = false;
            _isAttacking = true;
            _rb.velocity = Vector2.zero;
            ChangeAnimationState(ATTACK02);
        }
        if (InputManager.Attack03.triggered && !_isAttacking)
        {
            _canMove = false;
            _isAttacking = true;
            _rb.velocity = Vector2.zero;
            ChangeAnimationState(ATTACK03);
        }

        // Check if attack animation has finished
        if (_isAttacking && IsAnimationFinished())
        {
            _isAttacking = false; // Reset the attacking flag
            _canMove = true;
        }
    }


    protected void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;

        _animator.Play(newState);

        currentState = newState;

    }

    protected bool IsAnimationFinished()
    {
        AnimatorStateInfo stateInfo = _animator.GetCurrentAnimatorStateInfo(0);

        bool isAttack01Finished = stateInfo.IsName(ATTACK01) && stateInfo.normalizedTime >= 1.0f;
        bool isAttack02Finished = stateInfo.IsName(ATTACK02) && stateInfo.normalizedTime >= 1.0f;
        bool isAttack03Finished = stateInfo.IsName(ATTACK03) && stateInfo.normalizedTime >= 1.0f;

        return isAttack01Finished || isAttack02Finished || isAttack03Finished;
    }

    private void FlipCharacter()
    {
        _isFacingRight = !_isFacingRight;

        Vector3 characterScale = transform.localScale;
        characterScale.x *= -1;
        transform.localScale = characterScale;
    }
}
