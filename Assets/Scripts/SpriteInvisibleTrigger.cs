using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteInvisibleTrigger : MonoBehaviour
{
    
    //om spelaren kolliderar med en objekt så ska något hända
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
        }
    }
}

