using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CarMovementController : MonoBehaviour
{
    [SerializeField] private float _speed = 0.5f;
    public float pushDelta = 0.1f;
    private float _myTime = 0.0f;
    private float _nextPush = 0.5f;

    // Update is called once per frame
    void Update()
    {
        forwardMovement();
        pcInputs();

    }

    void forwardMovement()
    {
        _myTime = _myTime + Time.deltaTime;
        
        if( _myTime > _nextPush)
        {
            _nextPush = _myTime + pushDelta;
            transform.position += Vector3.forward;

            _nextPush = _nextPush - _myTime;
            _myTime = 0f;
        }
    }

    void pcInputs()
    {
        if(Input.GetKey("space"))   // Boost
        {
            transform.position += Vector3.forward;
        }
        if(Input.GetKeyDown("a"))       // Left
        {
            transform.position += Vector3.left;
        }
        if(Input.GetKeyDown("d"))       // Right
        {
            transform.position += Vector3.right;
        }
    }

}


