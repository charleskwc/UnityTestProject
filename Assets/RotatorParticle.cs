using UnityEngine;
using System.Collections;

public class RotatorParticle : MonoBehaviour {

	public float rotationSpeedParticle;
	public Vector3 originalPositionParticle; // point A

	// Use this for initialization
	void Start () {
		originalPositionParticle = transform.position;
		transform.Translate (1, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(originalPositionParticle, Vector3.up, rotationSpeedParticle * Time.deltaTime);
	}
}
