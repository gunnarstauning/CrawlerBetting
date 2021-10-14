using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacerMovement : MonoBehaviour
{
    public Transform goal;
    private GameManager gameManager;

    //private UnityEngine.AI.NavMeshAgent agent;

    void Start() 
    {
        //agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        gameManager = FindObjectOfType<GameManager>();
    }

    public void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Trigger")
        {
            //string triggerName = other.name;
            gameManager.changeCamera(other);
        }
    }
    
    public void startRace() 
    {
        //agent.destination = goal.position;
    }
}
