using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Add player movement topdown 2D and move with transform using WASD
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        Vector2 moveDirection = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            moveDirection += Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveDirection += Vector2.down;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            moveDirection += Vector2.left;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveDirection += Vector2.right;
        }


        // //Move player
        transform.Translate(new Vector3(moveDirection.x, moveDirection.y, 0) * speed * Time.deltaTime);
    }


}
