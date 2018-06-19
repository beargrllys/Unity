using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumps : MonoBehaviour
{ 
    private Transform _transform;
    private bool _isJumping;
    private float _posY;       
    private float _gravity;     
    private float _jumpPower;  
    private float _jumpTime;    


    void Start()
    {
        _transform = transform;
        _isJumping = false;
        _posY = transform.position.y;
        _gravity = 9.8f;
        _jumpPower = 5.5f;
        _jumpTime = 0.0f;
    }

    public void press_button() {
        if (!_isJumping) {
            _isJumping = true;
            _posY = _transform.position.y;
        }
    }

    void Update()
    {

        if (_isJumping)
        {
            Jump();
        }
    }

    void Jump()
    {
        
        float height = (_jumpTime * _jumpTime * (-_gravity) / 2) + (_jumpTime * _jumpPower);
        _transform.position = new Vector3(_transform.position.x, _posY + height, _transform.position.z);
        _jumpTime += Time.deltaTime;

        if (height < 0.0f)
        {
            _isJumping = false;
            _jumpTime = 0.0f;
            _transform.position = new Vector3(_transform.position.x, _posY, _transform.position.z);
        }
    }
}
