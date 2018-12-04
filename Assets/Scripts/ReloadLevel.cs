using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ReloadLevel : MonoBehaviour
{
    public int minimumScoreNeeded = 0;
    public string sceneToLoad = "SampleScene";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Om en karaktär med tag "Player" (spelaren i detta fall) kolliderar och har lika med eller mer än minimum coin poäng, ladda om nivån "SampleScene" (nuvarande nivån).
        if(collision.tag == "Player" && Coin.score >= minimumScoreNeeded)
        {
            SceneManager.LoadScene(sceneToLoad);
            
        }
    }

}
