﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Mirror;

public class PlayMove : NetworkBehaviour
{
    private CharacterController controller;
    private Vector3 pVelocity;
    public float speed = 20f;
    public bool shoot;

    public Camera ca;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        SphereCollider s = GetComponent<SphereCollider>();
        if(!isLocalPlayer){
            ca.gameObject.SetActive(false);
            s.enabled = true;
            controller.enabled = false;
        }
        else{
            s.enabled = false;
            // controller.enabled = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(shoot){
            UnityEngine.Debug.Log("shoot is working");
        }
    }

    public void OnShootPressed(){
        shoot = true;
    }
    public void ProcessMove(Vector2 input){
        if(!isLocalPlayer){
            return;
        }
        //UnityEngine.Debug.Log("stuff");
        Vector3 direction = Vector3.zero;
        //direction.x = input.x;
        direction.y = input.y;
        controller.Move(transform.TransformDirection(direction) * speed * Time.deltaTime);

    }
}