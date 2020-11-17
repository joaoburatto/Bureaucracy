using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapEditorMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float acceleration;

    [SerializeField] private float mouseSensibility = 5;
    [SerializeField] private float horizontal;
    [SerializeField] private float vertical;
    private void Update()
    {
        horizontal = Mathf.Lerp(horizontal,Input.GetAxis("Horizontal"), Time.deltaTime * acceleration);
        vertical = Mathf.Lerp(vertical,Input.GetAxis("Vertical"), Time.deltaTime * acceleration);

        Vector3 movement = transform.forward * vertical + transform.right * horizontal;
        if (Input.GetKey(KeyCode.LeftShift))
            movement *= 2.8f;
        movement = movement + transform.position;

        Vector3 rotation =  new Vector3(-Input.GetAxis("Mouse Y") * mouseSensibility * 10, Input.GetAxis("Mouse X") * mouseSensibility * 10);
        rotation = Vector3.Lerp(transform.rotation.eulerAngles, rotation + transform.rotation.eulerAngles, Time.deltaTime);
        
        transform.rotation = Quaternion.Euler(rotation);

        transform.position = Vector3.Lerp(transform.position, movement, Time.deltaTime * speed);
    }
}
