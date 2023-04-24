using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public Nave _player;


    public void leftDown()
    {
        _player.Left(true);

    }

    public void leftUp()
    {
        _player.Left(false);

        
    }

    public void rightDown()
    {
        _player.Right(true);


    }

    public void rightUp()
    {
        _player.Right(false);

        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
