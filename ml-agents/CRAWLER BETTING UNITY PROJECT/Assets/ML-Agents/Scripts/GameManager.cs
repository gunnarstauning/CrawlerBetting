using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject phone;
    public Camera mainCamera;

    public float playerMoney;
    public Text moneyText;

    public float timeBeforeRace = 20f;
    public float time = 20f;
    public Text timeText;

    public GameObject[] racers;

    public float transitionSpeed;
    public Transform currentView;
    public Transform[] cameras;
    public GameObject[] triggers;

    private string STATE = "BET_STATE";

    // Start is called before the first frame update
    void Start()
    {
        UpdateMoney();
    }

    // Update is called once per frame
    void Update()
    {
        switch(STATE)
        {
            case "BET_STATE":
                time -= Time.deltaTime;
                float timeActual = Mathf.Round(time % 60) ;
                timeText.text = "Race begins in " + timeActual.ToString();

                if (timeActual < 0) 
                {
                    BeginRace();
                }
                break;
            case "RACE_STATE":
                //Camera Movement
                mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, currentView.transform.position, Time.deltaTime * transitionSpeed);

                //Camera Angle
                Vector3 currentAngle = new Vector3(
                Mathf.LerpAngle(mainCamera.transform.rotation.eulerAngles.x, currentView.transform.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
                Mathf.LerpAngle(mainCamera.transform.rotation.eulerAngles.y, currentView.transform.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed),
                Mathf.LerpAngle(mainCamera.transform.rotation.eulerAngles.z, currentView.transform.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed));

                mainCamera.transform.eulerAngles = currentAngle;
                break;
            default:
                break;
        }
        
    }

    public void Bet ()
    {
        playerMoney -= 10;
        UpdateMoney();
    }

    private void BeginRace() 
    {
        time = timeBeforeRace;
        //RacerMovement raceMovement = racers[0].GetComponent<RacerMovement>();
        foreach(GameObject racer in racers)
        {
            racer.GetComponentInChildren<Rigidbody>().isKinematic = false;
        }
        //raceMovement.startRace();
        phone.SetActive(false);
        mainCamera.transform.position = cameras[0].transform.position;
        Vector3 currentAngle = new Vector3 (
            currentView.transform.rotation.eulerAngles.x,
            currentView.transform.rotation.eulerAngles.y,
            currentView.transform.rotation.eulerAngles.z
        );
        mainCamera.transform.eulerAngles = currentAngle;
        STATE = "RACE_STATE";
    }

    public void changeCamera(Collider other) 
    {
        switch(other.name)
        {
            case "Trigger1":
                currentView = cameras[0];
                break;
            case "Trigger2":
                currentView = cameras[1];
                break;
            case "Trigger3":
                currentView = cameras[2];
                break;
            case "Trigger4":
                currentView = cameras[3];
                break;
            case "Trigger5":
                currentView = cameras[4];
                break;
            case "Trigger6":
                currentView = cameras[5];
                break;
            case "Trigger7":
                currentView = cameras[6];
                break;
            case "Trigger8":
                currentView = cameras[7];
                break;
            case "Trigger9":
                currentView = cameras[8];
                break;
            case "Trigger10":
                currentView = cameras[9];
                break;
            default:
                Debug.Log("ERROR: Change Camera Failed");
                break;
        }

        other.gameObject.SetActive(false);
    }

    private void ResetRace()
    {
        phone.SetActive(true);
        time=timeBeforeRace;
    }

    private void UpdateMoney() 
    {
        moneyText.text = "Money: " + playerMoney.ToString() + "$";
    }
}
