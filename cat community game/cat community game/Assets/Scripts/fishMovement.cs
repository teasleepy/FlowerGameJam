using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
public class fishMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();

        
    }

    
    private void Update()
    {
        int fishx = 0;
        fishx++;

        //body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);
        body.velocity = new Vector2(fishx* speed, body.velocity.y);
    }

  
}