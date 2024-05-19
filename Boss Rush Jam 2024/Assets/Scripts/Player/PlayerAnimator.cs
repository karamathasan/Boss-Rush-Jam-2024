using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField]
    internal Player player;
    [SerializeField]
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    internal void idle()
    {
        anim.Play("idle");
    }
    internal void walkingHorizontal()
    {
        anim.Play("walkingHorizontal");
    }

    internal void walkingUp()
    {
        //transform.localScale = new Vector3(1, 1, 1);
        anim.Play("walkingUp");
    }

    internal void walkingDown()
    {
        //transform.localScale = new Vector3(1, 1, 1);
        anim.Play("walkingDown");
    }

    internal void walkDirection(Vector2 direction)
    {
        if (direction.Equals(Vector2.zero))
        {
            idle();
            return; 
        }

        if (Mathf.Abs(direction.x) > 0) { 
            transform.localScale = new Vector3(direction.x, 1, 1);
            walkingHorizontal();
        }

        if (direction.y > 0)
        {
            walkingUp();
        }

        if (direction.y < 0)
        {
            walkingDown();
        }
    }
}
