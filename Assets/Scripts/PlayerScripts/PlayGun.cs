using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayGun : MonoBehaviour
{
    private PlayMove _input;
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private GameObject bulletPoint;
    [SerializeField]
    private float bulletSpeed = 600;
    // Start is called before the first frame update
    void Start()
    {
        _input = transform.root.GetComponent<PlayMove>();
    }

    // Update is called once per frame
    void Update()
    {   
        
        bool enterKeyPressed = Keyboard.current.enterKey.wasPressedThisFrame;
        if(enterKeyPressed){
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
