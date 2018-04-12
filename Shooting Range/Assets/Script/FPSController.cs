using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(CharacterController))]
public class FPSController : MonoBehaviour {

	public float movementSpeed = 5.0f;
	public float mouseSensitivity = 2.0f;
	float verticalRotation = 0;
	public float jumpHight = 5.0f;
	public float verticalCameraLimit = 60.0f;

	float verticalVelocity = 0;

	CharacterController characterController;

	// Use this for initialization
	void Start () 
	{
		characterController = GetComponent<CharacterController> ();

		Screen.lockCursor = true;
		//Cursor.lockState
	}
	
	// Update is called once per frame
	void Update () 
	{
		

		//Rotation with mouse
		float horizontalRotation = Input.GetAxis("Mouse X") * mouseSensitivity;
		transform.Rotate (0, horizontalRotation, 0);

		verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity;
		verticalRotation = Mathf.Clamp (verticalRotation, -verticalCameraLimit, verticalCameraLimit);

		Camera.main.transform.localRotation = Quaternion.Euler (verticalRotation, 0, 0);


		//Movement
		float verticalSpeed = Input.GetAxis ("Vertical") * movementSpeed;
		float horizontalSpeed = Input.GetAxis ("Horizontal") * movementSpeed;

		verticalVelocity += Physics.gravity.y * Time.deltaTime;

		if (characterController.isGrounded && Input.GetButtonDown ("Jump"))
		{
			verticalVelocity = jumpHight;
		}

		Vector3 speed = new Vector3 (horizontalSpeed, verticalVelocity, verticalSpeed);

		speed = transform.rotation * speed;

		characterController.Move (speed * Time.deltaTime);

	}



}
