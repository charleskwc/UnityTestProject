#pragma strict

function Start () {

}

// Copied from YouTube, TwinTornadoes "#2 Unity3D Basics Tutorial: Making a video game"
var speed = 3.0;
var rotateSpeed = 3.0;

function Update () {

	var controller : CharacterController = GetComponent(CharacterController);
	
	// Rotate around y - axis
	transform.Rotate(0, Input.GetAxis ("Horizontal") * rotateSpeed, 0);
	
	// Move Forward / Backward 
	var forward = transform.TransformDirection(Vector3.forward);
	var curSpeed = speed * Input.GetAxis ("Vertical");
	controller.SimpleMove(forward * curSpeed);
	
}

@script RequireComponent(CharacterController)