using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CarMovementController : MonoBehaviour
{
    [SerializeField] private float _speed = 1f, _boostDelta = 0f, _normalDelta = 0.2f;
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
            transform.position += (Vector3.forward * _speed);

            _nextPush = _nextPush - _myTime;
            _myTime = 0f;
        }
    }

    void pcInputs()
    {
        if(Input.GetKeyDown("space"))   // Boost
        {
            Debug.Log("space press");
            // transform.position += (Vector3.forward * Time.deltaTime * _speed * _boostDelta);
            pushDelta = _boostDelta;
        }
        if(Input.GetKeyUp("space"))
        {
            pushDelta = _normalDelta;
        }
        if(Input.GetKeyDown("a"))       // Left
        {
            Debug.Log("A");
            transform.position += Vector3.left*3;
        }
        if(Input.GetKeyDown(KeyCode.D))       // Right
        {
            Debug.Log("press D");
            transform.position += Vector3.right*3;
        }
    }

}


