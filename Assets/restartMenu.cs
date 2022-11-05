using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartMenu : MonoBehaviour
{

    public GameObject restartMenuUI;
    public GameObject scndpauseMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver(){
        restartMenuUI.SetActive(true);
        scndpauseMenuUI.SetActive(false);
    }
    
    public void QuitButton2(){
        Application.Quit();
    }
    public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
