using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public CrawlerAgent crawler;
    //private bool targetHit = false;

    /*private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "agent")
        {
            if(crawler.targetNum <= 12)
            {
                crawler.targetNum++;
                crawler.FindNextTarget();
            }
        }
    }*/
}
