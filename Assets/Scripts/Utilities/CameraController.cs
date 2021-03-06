﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;       //Public variable to store a reference to the player game object


	public Vector3 offset = new Vector3(0,0,-40);         //Private variable to store the offset distance between the player and camera

	// Use this for initialization
	void Start () 
	{
		
		//Calculate and store the offset value by getting the distance between the player's position and camera's position.
	}

	// LateUpdate is called after Update each frame
	void LateUpdate () 
	{
		if(player == null)
			player = GameManager.instance.player.gameObject;
		// Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
		transform.position = player.transform.position + offset;
	}
}