using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Yellow" || other.tag == "Green" || other.tag == "Purple" || other.tag == "Orange" || other.tag == "Red")
        {
            Debug.Log("Racer Detected");
            gameManager.RaceWinner(other.tag);
            Debug.Log("Interacted with " + other.tag);
        } else 
        {
            Debug.Log("Interacted with " + other.tag);
        }
    }
}

//yellow green purple orange red