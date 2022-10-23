using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    private GameObject gameOverText;

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver)
        {
            EndGame(); // Start EndGame Method
        }
        else
            gameOverText.gameObject.SetActive(false); // Keep UI Text for GameOver hidden
    }
    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0; // Freeze Time
    }
}
