﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Gun : MonoBehaviour
{
    private PlayerMove _input;
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private GameObject bulletPoint;
    [SerializeField]
    private float bulletSpeed = 600;
    // Start is called before the first frame update
    void Start()
    {
        _input = transform.root.GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {   
        
        bool spaceKeyPressed = Keyboard.current.spaceKey.wasPressedThisFrame;
        if(spaceKeyPressed){
            UnityEngine.Debug.Log("shoot is working");
            GameObject bullet = Instantiate(bulletPrefab,bulletPoint.transform.position,transform.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
            Destroy(bullet,3);

        }
    }

    void Shoot()
    {
        Debug.Log("shoot is working");
    }
}
