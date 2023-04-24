using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour 
{
  public float _speed = 0;
    [SerializeField]private bool _left ;
    [SerializeField]private bool _right;
    private Rigidbody _rb;

    public void Left(bool value)
    {
        _left = value;

    }

     public void Right(bool value)
    {
        _right = value;

    }

    void Move(Vector3 velocity)
    {
        _rb.velocity = velocity;
    }

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_left){ Move(Vector3.left*_speed);
        }
        if(_right){ Move(Vector3.right*_speed);
        }
    }

    
}
