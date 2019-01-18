using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    public float speed = 25f;
    public bool Left = true;


    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        //Om råttan kollar åt vänster, gör vector3 till en vector2 (xyz till xy) och gå åt vänster håll
        if (Left == true)
        {
            rbody.MovePosition(rbody.position + (-(Vector2)transform.right *  Time.deltaTime));
            transform.localScale = new Vector3(1, 1, 1);
        }
        //annars, gå åt höger håll
        else
        {
            rbody.MovePosition(rbody.position + ((Vector2)transform.right * Time.deltaTime));
            transform.localScale = new Vector3(-1, 1, 1);
        }

    }

    //Om råttan kolliderar med ett föremål med taggen "InvisibleWall", gå åt motsatta håll.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "InvisibleWall")
            Left = !Left;
    }


}
