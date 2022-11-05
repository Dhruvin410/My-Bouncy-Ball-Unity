
using UnityEngine;

public class playerFollow : MonoBehaviour {

	public Transform playerPoss;
	public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(playerPoss.position);
		transform.position = playerPoss.position + offset;
	}
}
