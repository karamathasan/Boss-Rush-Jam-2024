using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movSpeed = 4;
    public float stamina = 100;
    public float hp = 100;

    public Rigidbody2D rb;
    public Animator anim;

    [SerializeField]
    internal PlayerMovement playerMovement;
    [SerializeField]
    internal PlayerInput playerInput;
    [SerializeField]
    internal PlayerActions playerActions;
    [SerializeField]
    internal PlayerAnimator playerAnimator;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponentInParent<Rigidbody2D>();
    }
}
