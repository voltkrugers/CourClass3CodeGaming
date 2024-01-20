using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public float MouseSensitivity = 50f;
    private float minCameraView = -70f;
    private float maxCameraView = 80f;

    private float xRotation = 0f;
    private Camera camera;
    private CharacterController charController;

    void Start()
    {
        charController = GetComponent<CharacterController>();
        camera = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 movement = transform.forward * vertical + transform.right * horizontal;
        charController.Move(movement * (Time.deltaTime * MoveSpeed));

        float mouseX = Input.GetAxis("Mouse X") * MouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * MouseSensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, minCameraView, maxCameraView);
        
        camera.transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
        transform.Rotate(Vector3.up*mouseX);
    }
}
