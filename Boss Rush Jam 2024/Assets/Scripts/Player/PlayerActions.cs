using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerActions : MonoBehaviour
{
    // DEFINITIONS FOR DIFFERENT ACTIONS THE PLAYER CAN TAKE
    // ATTACKING, DODGING, GRABBING ITEMS
    // Start is called before the first frame update
    [SerializeField]
    internal Player player;
    [SerializeField]
    internal GameObject primaryShotPrefab;
    internal Queue<GameObject> swappableShots;
    internal Stack<GameObject> shotStack;
    [SerializeField]
    internal float shootSpeed = 5;


    void Start()
    {
        swappableShots = new Queue<GameObject>(3);
    }

    internal void PrimaryShot(Vector3 direction)
    {
        direction.Normalize();
        Quaternion rotation = Quaternion.Euler(new Vector3(0, 0, Vector2.SignedAngle(new Vector2(1,0),direction)));
        GameObject primaryShot = Instantiate(primaryShotPrefab, player.transform.position, rotation);
        primaryShot.GetComponent<Rigidbody2D>().AddForce(direction * shootSpeed, ForceMode2D.Impulse);
        swappableShots.Enqueue(primaryShot);
    }

    internal void ExchangeWithShot()
    {
        if (swappableShots.Count == 0)
        {
            return;
        }
        GameObject swappingObj = swappableShots.Dequeue();
        Vector3 temp = swappingObj.transform.position;
        swappingObj.transform.position = player.transform.position;
        Rigidbody2D rb = swappingObj.GetComponent<Rigidbody2D>();
        rb.AddForce(-2 * shootSpeed * rb.velocity.normalized, ForceMode2D.Impulse);
        player.transform.position = temp;
    }

    internal void SecondaryShot(Vector2 direction)
    {
        GameObject secondaryShot = Instantiate(primaryShotPrefab, player.transform.position, Quaternion.Euler(direction));
        secondaryShot.GetComponent<Rigidbody2D>().AddForce(direction.normalized, ForceMode2D.Impulse);
    }
}
