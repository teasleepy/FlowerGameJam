using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerManager manager = collision.GetComponent<PlayerManager>();
        if (manager)
        {
            manager.PickUpItem();

            //reset the fish's position

            float randomNumberX = Random.Range(-50, -25);
            float randomNumberY = Random.Range(-2, -4);


            transform.position = new Vector2(randomNumberX, randomNumberY);
        }
    }
}
