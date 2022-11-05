using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onCollosion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public playerMovement movement;
	public Text gameIsOver;
	public GameObject gameend;
	public GameObject scriptpauseUI;
	public GameObject scriptRestrtMenu;

	

	public void OnCollisionEnter(Collision col) {
		
	if(col.transform.tag == "obsTag")
	{
		
		bool gameHasEnded = false;

		if(gameHasEnded == false){
			gameHasEnded = true;
		
		//timerText.text = ("Game Over");
		//Debug.Log("Game over");
		//Destroy(gameObject);
		//Time.timeScale = 0;
		//rigidbody.velocity = Vector3.zero;
		movement.enabled = false;
		FindObjectOfType<restartMenu>().GameOver();
		gameIsOver.text = "Game Over";
		//Destroy(gameObject);
		//FindObjectOfType<AudioManager>().Play("granade");
		FindObjectOfType<AudioManager>().Play("gameover");

		}
		
	}

	if(col.transform.tag == "gameovr")
	{
		
		gameend.SetActive(true);
		scriptpauseUI.SetActive(false);
		scriptRestrtMenu.SetActive(false);
		
	}

	}

	}

