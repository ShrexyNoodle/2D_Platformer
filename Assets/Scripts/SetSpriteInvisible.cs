using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteInvisible : MonoBehaviour
{

    // Use this for initialization
    void Start()
        //När spelaren sätter igång spelet, gör så att ett par colliders sprites blir osynliga
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }

}

