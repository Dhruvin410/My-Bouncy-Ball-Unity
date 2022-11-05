using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		transform.position += new Vector3(0.1f,0,0) * Time.timeScale;

		//Vector3 ballY;
	 	//ballY = new Vector3(transform.position.x, transform.position.y, transform.position.z);

		//Debug.Log(ballY);

		if(Input.GetMouseButtonDown(0))
		{
			GetComponent<Rigidbody>().AddForce(Vector3.up * 3,ForceMode.VelocityChange);
			FindObjectOfType<AudioManager>().Play("jump");
		}
			//float t = Time.time;
			//timerText.text = t.ToString("f");
		//timerText = Time.time.ToString("f2");

			//float t = GameObject.Find("plater").transform.position;
			//timerText.text = t.ToString("f");
		
	}
}
