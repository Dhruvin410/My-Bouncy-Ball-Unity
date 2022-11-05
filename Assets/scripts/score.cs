
using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour {

	public Transform gameObject;
	public Text scoreText;
	
	//public float timeStart;
	//public Text scoreText;

	// Use this for initialization
	void Start () {
		//scoreText.text = 0f.ToString();
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log(gameObject.position.x);
		//timeStart = timeStart + Time.deltaTime;
		//scoreText.text = timeStart.ToString("f2");

		scoreText.text = gameObject.position.x.ToString("f1");
		//Debug.Log(Time.time.ToString("f1"));
		//timeStart.text = Time.time.ToString();
		
	}
}
