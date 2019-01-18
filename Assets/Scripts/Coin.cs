using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //static betyder att objektet inte kan påverkas i unity eller i ett annat skript utanför detta skript
    public static int score;

    public int amount = 2;

    public float spinSpeed = 180;

    //Rotera myntet konstant runt sin y axel
    private void Update()
    {
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }
    //Om spelaren kolliderar med myntet, visa i User Interface mängd score man fått från myntet och förstör myntet
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Coin.score += amount;
            Destroy(gameObject);
        }
    }
}
