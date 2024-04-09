// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PlayerLook : MonoBehaviour
// {
//     public Camera ca;
//     private float xRotate = 0f;

//     public float xSensitivity = 30f;
//     public float ySensitivity = 30f;

//     public void ProcessLook(Vector2 input){
//         float mouseX = input.x;
//         float mouseY = input.y;
//         xRotate -= (mouseY * Time.deltaTime) * ySensitivity;
//         xRotate = Mathf.Clamp(xRotate,-80f,80f);
//         ca.transform.localRotation = Quaternion.Euler(xRotate,0,0);
//         transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);
//     }
//     // Start is called before the first frame update
//     // void Start()
//     // {
        
//     // }

//     // // Update is called once per frame
//     // void Update()
//     // {
        
//     // }
// }
