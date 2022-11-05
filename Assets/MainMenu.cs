using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public GameObject startMenuUI;
    public GameObject objMenuUI;

    public void PlayGame(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void OptionsMenu(){
        startMenuUI.SetActive(false);
        objMenuUI.SetActive(true);
    }

    public void OptionsBackButton()
    {
        startMenuUI.SetActive(true);
        objMenuUI.SetActive(false);
    }

    public void QuitGame(){
        Application.Quit();
    }
}
