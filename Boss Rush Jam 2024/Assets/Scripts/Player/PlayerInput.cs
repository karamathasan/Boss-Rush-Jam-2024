using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

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

    internal void OnWalk(InputValue value )
    {
        Vector2 direction;        
        direction = value.Get<Vector2>();
        player.playerMovement.Walk(direction);
    }

    //private void SwapPosition(InputValue value)
    //{

    //}
    private void FixedUpdate()
    {
        
    }
    internal void PrimaryShot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Vector2 direction = Vector2.Angle(player.rb.position, Input.mousePosition);
            Vector2 direction = (Vector2)Input.mousePosition - player.rb.position;
            player.playerActions.PrimaryShot(direction);
        }
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
