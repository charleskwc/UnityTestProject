using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public GUIText countText;
	public GUIText winText;
	private int count;

	void Start ()
	{
		count = 0;
		SetCountText ();
		winText.text = "";
	}
	// Use this for initialization
	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rigidbody.AddForce(movement * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		//Destroy(other.gameObject);
		if (other.gameObject.tag == "Pickup")
		{
			other.gameObject.SetActive (false);
			count++;
			SetCountText ();
		}
	}

	void SetCountText () {
		countText.text = "Count: " + count.ToString ();
		if (count >= 12) {
			winText.text = "YOU WIN!";
		}
	}

}
