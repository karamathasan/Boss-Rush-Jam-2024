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
        player.rb.velocity = direction * player.movSpeed;
    }

}
