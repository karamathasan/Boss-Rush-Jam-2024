using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTestBehavior : MonoBehaviour
{
    [SerializeField]
    internal EnemyTest enemy;

    void Start()
    {
        enemy = GetComponent<EnemyTest>();
    }

    internal BehaviorTree getTree()
    {
        ETHealthSelection head;
        EnemyTestWalking e = new EnemyTestWalking(enemy);
        ETKeepDistance kd = new ETKeepDistance(enemy);
        ETCloseDistance cd = new ETCloseDistance(enemy);

        head = new ETHealthSelection(enemy, kd, cd);

        return new BehaviorTree(enemy, head);
    }
}
