using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.MoveActions move;
    private PlayerMove motor;
    private PlayerLook look;
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }
    void Awake(){
        playerInput = new PlayerInput();
        move = playerInput.Move;
        motor = GetComponent<PlayerMove>();
        look = GetComponent<PlayerLook>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        motor.ProcessMove(move.Movement.ReadValue<Vector2>());
        //motor.onShootPressed();
    }
    void LateUpdate(){
        look.ProcessLook(move.Look.ReadValue<Vector2>());
    }
    private void OnEnable(){
        move.Enable();
    }
    private void OnDisable(){
        move.Disable();
    }
}
