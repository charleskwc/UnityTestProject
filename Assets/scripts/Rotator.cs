using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
	public float rotationSpeed;
	public Vector3 originalPosition; // point A

	void Start (){
		//rotationSpeed = 45;
		originalPosition = transform.position;
		transform.Translate (1, 0, 0);
	}

	void Update () {
		//Vector3 axis = B - A;// calculate axis
		transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
		transform.RotateAround(originalPosition, Vector3.up, rotationSpeed * Time.deltaTime);
	}
}