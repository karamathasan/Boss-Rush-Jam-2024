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
        //if(player.playerInput)
        anim.Play("walkingHorizontal");
    }

    internal void walkingUp()
    {
        anim.Play("walkingUp");
    }

    internal void walkingDown()
    {
        anim.Play("walkingDown");
    }
}
