using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis("Vertical");
		float moveVertical = Input.GetAxis("Horizontal");

		Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);

		rigidbody.AddForce(movement*speed*Time.deltaTime);

	}

}
