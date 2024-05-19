using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrimary : MonoBehaviour, Projectile
{
    [SerializeField]
    public LayerMask enemyLayer;
    public float speed = 5;
    [SerializeField]
    public float radius = 2;
    [SerializeField]
    private float damage;
    public void Collide()
    {
        Collider2D[] enemiesHit = Physics2D.OverlapCircleAll(transform.position, radius, enemyLayer);
        foreach(Collider2D e in enemiesHit)
        {
            e.GetComponent<EnemyTest>().sensing.takeDamage(damage);
        }
        if (enemiesHit.Length > 0)
        {
            Destroy(gameObject);
        }
    }

    public void OutOfBounds()
    {
        //throw new System.NotImplementedException();
        //Player p = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        //if (Vector2.Distance(transform.position,p.rb.position) > 20)
        //{
            
        //    Destroy(gameObject);
        //}
    }

    public void Shoot()
    {
        throw new System.NotImplementedException();
    }

    void Update()
    {
        Collide();
        OutOfBounds();
    }
}
