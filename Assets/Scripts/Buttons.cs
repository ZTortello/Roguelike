using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void Starting()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit() 
    {
        Application.Quit();
        Debug.Log("Goodbye!");
    }

}
