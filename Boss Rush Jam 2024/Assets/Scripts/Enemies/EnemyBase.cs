using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBase : MonoBehaviour, Ikillable
{
    protected BehaviorTree behavior;
    public void Die()
    {
        Destroy(gameObject);
    }
    public void Despawn()
    {
        Die();
    }
}
