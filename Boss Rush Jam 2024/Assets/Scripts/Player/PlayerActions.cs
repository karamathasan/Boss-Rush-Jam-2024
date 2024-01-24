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


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void PrimaryShot(Vector2 direction)
    {
        GameObject primaryShot = Instantiate(primaryShotPrefab, player.transform.position, Quaternion.Euler(direction));
        primaryShot.GetComponent<Rigidbody2D>().AddForce(direction.normalized, ForceMode2D.Impulse );
    }

    internal void ExchangeWithShot()
    {

    }

    internal void SecondaryShot(Vector2 direction)
    {
        GameObject secondaryShot = Instantiate(primaryShotPrefab, player.transform.position, Quaternion.Euler(direction));
        secondaryShot.GetComponent<Rigidbody2D>().AddForce(direction.normalized, ForceMode2D.Impulse);
    }
}
