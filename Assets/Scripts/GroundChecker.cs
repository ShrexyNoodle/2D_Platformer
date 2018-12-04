using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public bool isGrounded;

    //Om spelaren är på marken, skall man kunna hoppa.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
    }
    //Om spelaren inte är på marken skall man inte kunna hoppa.
    private void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false;
    }
}
