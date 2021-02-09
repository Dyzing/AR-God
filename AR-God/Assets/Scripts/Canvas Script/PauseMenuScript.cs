using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuScript : MonoBehaviour
{
    [SerializeField]
    GameObject menuObject;

    [SerializeField]
    Text resumeButton;


    public bool isActive = false;
    public bool isEnd = false;


    void Update()
    {
        if(isActive)
        {
            menuObject.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            menuObject.SetActive(false);
            Time.timeScale = 1;
        }

        if (isEnd) {
            menuObject.SetActive(true);
            resumeButton.text = "Restart";
        }

    }

    public void RESUME_BUTTON()
    {
        if (!isEnd) {
            isActive = !isActive;
        }
        else {
            Application.LoadLevel("Demo");
        }
    }

    public void QUIT_BUTTON()
    {
        Application.Quit();
    }

    public void PAUSE_BUTTON()
    {
        if (!isEnd)
        {
            isActive = !isActive;
        }
    }
}
