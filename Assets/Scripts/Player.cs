using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float potenciaMotor= 12.0f;
    [SerializeField] private float potenciaRotacion = 2.0f;

    private float dirRotacion = 0.0f;
    private float dirAvance=0.0f;

    private Rigidbody2D rBody = null;


    private void Awake() {
        rBody = GetComponent<Rigidbody2D>();
    }    

    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        PlayerInput();
    }

    private void PlayerInput()
    {
        dirAvance = Input.GetAxis("Vertical");
        dirRotacion=Input.GetAxis("Horizontal");

    }

    private void FixedUpdate() {
        rBody.AddTorque(dirRotacion*-potenciaRotacion);
        rBody.AddForce(dirAvance*potenciaMotor*transform.up);
    }
}
