using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    internal Player player;
    private PlayerControls playerControls;
    // Start is called before the first frame update
    void Start()
    {
        playerControls = new PlayerControls();
    }

    // Update is called once per frame

    //internal void OnWalk(InputValue value)
    //{
    //    Vector2 direction;        
    //    direction = value.Get<Vector2>();
    //    player.playerMovement.Walk(direction);
    //}

    internal void Walk()
    {
        Vector2 direction = Vector2.zero;

        if (Input.GetKey("a"))
        {
            direction.x = -1;
        }else if (Input.GetKey("d"))
        {
            direction.x = 1;
        }

        if (Input.GetKey("w"))
        {
            direction.y = 1;
        }else if (Input.GetKey("s"))
        {
            direction.y = -1;
        }

        player.playerMovement.Walk(direction);
    }

    //private void SwapPosition(InputValue value)
    //{

    //}
    private void FixedUpdate()
    {
        Walk();
        PrimaryShot();

    }
    internal void PrimaryShot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("left click");
            //Vector2 direction = Vector2.Angle(player.rb.position, Input.mousePosition);
            Vector2 direction = (Vector2)Input.mousePosition - player.rb.position;
            player.playerActions.PrimaryShot(direction);
        }
    }

    internal void pickUpPrimary()
    {
        //GameObject.FindObjectOfType<>

        //if (Input.GetKeyDown("e"))
        //{
        //    player.playerActions.swappableShots.Enqueue()
        //}
    }

    internal void SecondaryShot()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector2 direction = (Vector2)Input.mousePosition - player.rb.position;
            player.playerActions.SecondaryShot(direction);
        }
    }
}
