using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static Vector2 Movement;
    public static InputAction Attack01;
    public static InputAction Attack02;
    public static InputAction Attack03;

    private PlayerInput _playerInput;

    private InputAction _moveAction;
    private InputAction _attack01Action;
    private InputAction _attack02Action;
    private InputAction _attack03Action;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();

        _moveAction = _playerInput.actions["Move"];
        _attack01Action = _playerInput.actions["Attack01"];
        Attack01 = _attack01Action;
        _attack02Action = _playerInput.actions["Attack02"];
        Attack02 = _attack02Action;
        _attack03Action = _playerInput.actions["Attack03"];
        Attack03 = _attack03Action;

    }

    private void Update()
    {
        Movement = _moveAction.ReadValue<Vector2>();
    }



}
