using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clickToPop = 3; // How many clicks until the balloon pops
    public float scaleToIncrease = 0.10f; // Each time the balloon is clicked inflate by 10%
    public int scoreToGive = 100;
    public ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
      //Reference ScoreManager Componnent
      scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();  
    }

    void OnMouseDown()
    {
       clickToPop -= 1; // Reduce clicks by one

       //Inflate the Balloon a certain every time it is clicked on
       transform.localScale += Vector3.one * scaleToIncrease;
       
       if(clickToPop == 0)
       {
        // Send points to score manager and update the score
        scoreManager.IncreaseScoreText(scoreToGive);
        // Destory this balloon
         Destroy(gameObject);
       }

    }
}
