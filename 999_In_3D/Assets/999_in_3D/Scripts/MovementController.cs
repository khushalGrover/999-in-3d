using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float MoveSpeed = 10f;
    [SerializeField] private float _speed = 0.5f;
    public float pushDelta = 0.1f;
    private float _myTime = 0.0f;
    private float _nextPush = 0.5f;

    // Update is called once per frame
    void Update()
    {
        

        _myTime = _myTime + Time.deltaTime;
        
        if( _myTime > _nextPush)
        {
            _nextPush = _myTime + pushDelta;
            // transform.position += Vector3.forward;
            Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
            transform.position += direction * MoveSpeed * Time.deltaTime;
            transform.LookAt(transform.position + direction);

            _nextPush = _nextPush - _myTime;
            _myTime = 0f;
        }


    }
}
