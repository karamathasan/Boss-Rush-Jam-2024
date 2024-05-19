using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ETKeepDistance : ActionNode
{
    private EnemyTest enemy;
    //public ETKeepDistance() { }
    public ETKeepDistance(EnemyTest e)
    {
        behaviorAgent = e;
        enemy = behaviorAgent.GetComponent<EnemyTest>();
    }
    public override void Action()
    {
        if (enemy.sensing.getDistToPlayer() < 4)
        {
            Vector2 direction = enemy.sensing.getDirectionToPlayer();
            enemy.rb.velocity = -direction;
        }
        else enemy.rb.velocity = Vector2.zero;
    }
}
