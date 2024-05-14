using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    internal Player player;
    float kA = 1.5f;
    // Start is called before the first frame update
    internal void Walk(Vector2 direction)
    {
        //float e = player.movSpeed - player.rb.velocity.magnitude;
        //player.rb.AddForce(direction * e * kA, ForceMode2D.Force);
        //player.rb.AddForce(direction, ForceMode2D.Force);
        direction.Normalize();
        player.rb.velocity = direction * player.movSpeed;
        flip();
    }

    void flip()
    {


        if(player.rb.velocity.y > 0)
        {
            player.playerAnimator.walkingUp();
        }

        if (player.rb.velocity.y < 0)
        {
            player.playerAnimator.walkingDown();
        }

        if(player.rb.velocity.x > 0)
        {
            if(player.transform.localScale.x < 0){
                transform.localScale = new Vector3(1, 1, 1);
            }
            player.playerAnimator.walkingHorizontal();
        } 

        if (player.rb.velocity.x < 0)
        {
            if(player.transform.localScale.x > 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            player.playerAnimator.walkingHorizontal();
        }

        if (player.rb.velocity.x == 0 && player.rb.velocity.y == 0)
        {
            player.playerAnimator.idle();
            player.rb.transform.localScale = new Vector3(1, 1, 1);
            //return;
        }
    }

}
