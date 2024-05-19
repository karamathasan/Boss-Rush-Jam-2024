using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviorTree 
{
    protected TreeNode head;
    protected EnemyBase behaviorAgent;
    private TreeNode currentNode;

    public BehaviorTree(EnemyBase agent, TreeNode node)
    {
        behaviorAgent = agent;
        head = node;
        currentNode = head;
        head.updateChildrenAgents(agent);
        currentNode.updateChildrenAgents(agent);
    }

    public void Traverse()
    {
        while (currentNode.Advance() != null)
        {
            currentNode = currentNode.Advance();
        }
        currentNode = head;//restart 
    }
}
