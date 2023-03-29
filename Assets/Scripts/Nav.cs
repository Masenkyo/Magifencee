using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nav : MonoBehaviour
{
    public void GoToGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void GoToWin()
    {
        SceneManager.LoadScene("Win");
    }
    public void GoToStart()
    {
        SceneManager.LoadScene("Start");
    }
    public void GoToDead()
    {
        SceneManager.LoadScene("Dead");
    }
}