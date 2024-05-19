using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : EnemyBase
{
    [SerializeField]
    internal float maxHealth = 100;
    [SerializeField]
    internal float currentHealth;

    [SerializeField]
    internal Rigidbody2D rb;
    [SerializeField]
    internal EnemyTestSensing sensing;
    [SerializeField]
    internal EnemyTestBehavior behaviorData;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

    void Start()
    {
        behavior = behaviorData.getTree();      
    }

    // Update is called once per frame
    private void Update()
    {
        if (currentHealth < 0)
        {
            Die();
        }
        behavior.Traverse();
    }
}
