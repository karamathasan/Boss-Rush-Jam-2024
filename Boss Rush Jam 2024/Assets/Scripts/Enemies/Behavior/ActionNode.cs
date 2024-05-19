using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActionNode : TreeNode
{
    public abstract void Action();

    public override TreeNode Advance()
    {
        Action();
        return null;
    }

    public override void updateChildrenAgents(EnemyBase agent)
    {
        behaviorAgent = agent;
    }

    public override void addChild(TreeNode child )
    {
        children.Clear();
        return;
    }
}

