using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();

    }

    //check for arrow inputs
    private void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        //if(Input.GetKeyDown(KeyCode.S))
        //{
        //  Save();
        //}
    }

    //private void Save()
    //{
    //File.WriteAllText(Application.dataPath + "/save.txt", "test/n");
    //}
}