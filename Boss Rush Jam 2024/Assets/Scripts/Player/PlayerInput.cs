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
        }
        if (Input.GetKey("d"))
        {
            direction.x = 1;
        }
        if (Input.GetKey("a") && Input.GetKey("d"))
        {
            direction.x = 0;
        }

        if (Input.GetKey("w"))
        {
            direction.y = 1;
        }
        if (Input.GetKey("s"))
        {
            direction.y = -1;
        }
        if (Input.GetKey("w") && Input.GetKey("s"))
        {
            direction.y = 0;
        }

        bool keyUpdate = Input.GetKeyDown("a") || Input.GetKeyDown("s") || Input.GetKeyDown("d") || Input.GetKeyDown("w") ||
                         Input.GetKeyUp("a") || Input.GetKeyUp("s") || Input.GetKeyUp("d") || Input.GetKeyUp("w");
        if (keyUpdate)
        {
            player.playerAnimator.walkDirection(direction);
            player.playerMovement.Walk(direction);
        }
    }

    private void Update()
    {
        Walk();
        PrimaryShot();
        Swap();
    }

    internal void PrimaryShot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 screenPoint = Input.mousePosition;
            screenPoint.z = -Camera.main.transform.position.z;
            Vector2 direction = (Vector2)Camera.main.ScreenToWorldPoint(screenPoint) - player.rb.position;

            direction.Normalize();
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
            Vector3 screenPoint = Input.mousePosition;
            screenPoint.z = -Camera.main.transform.position.z;
            Vector2 direction = (Vector2)Camera.main.ScreenToWorldPoint(screenPoint) - player.rb.position;
        }
    }

    internal void Swap()
    {
        if (Input.GetKeyDown("space"))
        {
            player.playerActions.ExchangeWithShot();
        }
    }
}
