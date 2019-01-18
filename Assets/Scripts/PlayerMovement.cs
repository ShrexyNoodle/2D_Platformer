using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 6f;
    public float jumpSpeed = 5f;
    public float jumpTimeCounter;
    public float jumpTime;
    public GroundChecker groundCheck;



    private Rigidbody2D rbody;
    private bool isJumping;


    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Om spelaren trycker på "Horizontal" knapparna (dvs A, D, Vänster/Höger pilar eller använder joystick, gå åt vänster respektive höger.
        rbody.velocity = new Vector2(
            Input.GetAxisRaw("Horizontal") * moveSpeed,
            rbody.velocity.y);


        //Om "Player" trycker på Spacebar så skall spelarens karaktär hoppa.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Detta kan "Player" bara göra om karaktären är på marken
            if (groundCheck.isGrounded == true)
            {

                //När "Player" hoppar, blir isJumping boolen "true"
                isJumping = true;
                //jumpTimeCounter är hur länge "Player" kan hålla i Spacebar för att hoppa längre. Desto högre nummer, desto högre hoppar "Player"
                jumpTimeCounter = jumpTime;

                rbody.velocity = new Vector2(
                    rbody.velocity.x,
                    jumpSpeed);
            }


        }
        // Om "Player" håller ner Spacebar och hoppar och jumpTimeCounter är mer än 0 så skall "Player" hoppa högre och jumpTimeCounter skall minska så att spelaren faller till slut.
        //Om inte så skall isJumping boolen vara "False"
        if (Input.GetKey(KeyCode.Space) && isJumping == true)
        {

            if (jumpTimeCounter > 0)
            {
                rbody.velocity = Vector2.up * jumpSpeed;
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }

        }

    }
}
