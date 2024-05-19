using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TreeNode 
{
    protected EnemyBase behaviorAgent;
    protected List<TreeNode> children = new List<TreeNode>();
    public abstract TreeNode Advance();

    public virtual void addChild(TreeNode child)
    {
        children.Add(child);
    }

    public virtual void updateChildrenAgents(EnemyBase agent)
    {
        behaviorAgent = agent;
        foreach(TreeNode child in children)
        {
            child.updateChildrenAgents(agent);
        }
    }
}
