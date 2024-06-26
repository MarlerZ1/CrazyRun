using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLvls : MonoBehaviour
{
    public void LoadAboutAuthorScene()
    {
        SceneManager.LoadScene(1);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }
    
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
