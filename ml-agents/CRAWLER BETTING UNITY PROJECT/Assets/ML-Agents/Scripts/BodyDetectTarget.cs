using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyDetectTarget : MonoBehaviour
{
    private CrawlerAgent agent;
    private GameManager gameManager;

    void Start()
    {
        agent = this.GetComponentInParent<CrawlerAgent>();
        gameManager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "target")
        {
            agent.targetNum++;
            agent.FindNextTarget();
        }
        if (other.tag == "Trigger")
        {
            //string triggerName = other.name;
            gameManager.changeCamera(other);
        }
    }
}
