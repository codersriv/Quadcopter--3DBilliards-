using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Mirror;
public class InputManage : MonoBehaviour
{
    private PlayInput playerInput;
    private PlayInput.MoveActions move;
    private PlayMove motor;
    private PlayLook look;
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }
    void Awake(){
        playerInput = new PlayInput();
        move = playerInput.Move;
        motor = GetComponent<PlayMove>();
        look = GetComponent<PlayLook>();
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
