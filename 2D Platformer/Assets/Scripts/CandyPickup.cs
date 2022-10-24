using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CandyPickup : MonoBehaviour
{
    public int itemNumber; // Store item value
    public TextMeshProUGUI ItemsCollected; // Reference visual text UI elment to change
    public int oneCandy = 1;
    /* Start is called before the first frame update
    void Start()
    {
        
    }*/

    // This function Collects the Candy
    public void IncreaseNumber(int amount)
    {
        itemNumber += amount; //add amount to itemNumber
        UpdateNumberText();// Update the UI text
    }

    public void UpdateNumberText()
    {
        ItemsCollected.text = "Candy: "+ itemNumber + "/2"; // Updates the text to candy amount you grabbed
    }

     void OnTriggerEnter(Collider other)
    {
        IncreaseNumber(oneCandy); //Adds the one candy
        Destroy(gameObject); // Destroy this game object
    }
}   
