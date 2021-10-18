using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("CrawlerScene");
    }

    public void ReturnHome()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        //Application.Quit();



        //Only for Unity, not able to build with this line
        //Use the one above.
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
