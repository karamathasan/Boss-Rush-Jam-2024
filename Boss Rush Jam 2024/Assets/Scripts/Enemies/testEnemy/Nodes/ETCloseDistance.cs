using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ETCloseDistance : ActionNode
{
    private EnemyTest enemy;
    //public ETCloseDistance()
    //{
    //    enemy = behaviorAgent.GetComponent<EnemyTest>();
    //}
    public ETCloseDistance(EnemyTest e)
    {
        behaviorAgent = e;
        enemy = behaviorAgent.GetComponent<EnemyTest>();
    }

    public override void Action()
    {
        if (enemy.sensing.getDistToPlayer() > 2)
        {
            Vector2 direction = enemy.sensing.getDirectionToPlayer();
            enemy.rb.velocity = direction;
        }
        else enemy.rb.velocity = Vector2.zero;
        
    }
}
