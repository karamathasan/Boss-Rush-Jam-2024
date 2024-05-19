using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTestSensing : MonoBehaviour
{
    [SerializeField]
    internal EnemyTest enemy;
    void Awake()
    {
        enemy = GetComponent<EnemyTest>();
    }

    internal float getDistToPlayer()
    {
        GameObject p = GameObject.FindGameObjectWithTag("Player");
        Rigidbody2D prb = p.GetComponent<Rigidbody2D>();
        return Vector2.Distance(prb.position, enemy.rb.position);
    }

    internal Vector2 getDirectionToPlayer()
    {
        GameObject p = GameObject.FindGameObjectWithTag("Player");
        Rigidbody2D prb = p.GetComponent<Rigidbody2D>();
        return (prb.position - enemy.rb.position).normalized;
    }

    internal bool lowHealth()
    {
        return (enemy.currentHealth < enemy.maxHealth / 2);
    }

    internal void takeDamage(float damage)
    {
        enemy.currentHealth -= damage;
    }
}
