using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Quitter : MonoBehaviour
{
    public void Quit_Func()
    {
        Debug.Log("quit !");
        Application.Quit();     
    }
}