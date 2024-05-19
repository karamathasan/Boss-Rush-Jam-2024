using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ETHealthSelection : SelectorNode
{
    private EnemyTest enemy;

    public ETHealthSelection(EnemyTest e, TreeNode low, TreeNode high)
    {
        enemy = e;
        addChild(low);
        addChild(high);
    }

    //public ETHealthSelection(TreeNode low, TreeNode high) {
    //    addChild(low);
    //    addChild(high);
    //    enemy = behaviorAgent.GetComponent<EnemyTest>();
    //}

    public override TreeNode Advance()
    {
        if (enemy.sensing.lowHealth() == true)
        {
            return children[0];
        }
        else
        {
            return children[1];
        }
    }
}
