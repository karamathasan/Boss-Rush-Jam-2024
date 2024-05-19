using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTestWalking : ActionNode
{
    public EnemyTestWalking() { }
    public EnemyTestWalking(EnemyTest e)
    {
        behaviorAgent = e;
    }

    public override void Action()
    {
        behaviorAgent.GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0);
    }
}
