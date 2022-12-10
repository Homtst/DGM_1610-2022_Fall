using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool hasFlag;
    public bool flagplaced;

    // Start is called before the first frame update
    void Start()
    {
        // Flag Bools
        hasFlag = false;
        flagplaced = false;
    }

    void Update()
    {
        if(flagplaced)
        {
            WinGame();
        }
    }

    void WinGame()
    {
        Debug.Log("You've Won the Game!");
        Time.timeScale = 0;
    }

    public void PlaceFlag()
    {
        flagplaced = true;
    }
}
