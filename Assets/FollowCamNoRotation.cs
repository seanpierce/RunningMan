using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamNoRotation : MonoBehaviour {

	// // reference to the player object
	// public GameObject player;
	//
	// // distance between camera and player
	// // Vector3 is a refernece to xyz planes
	// private Vector3 offset;
	//
	// // Use this for initialization
	// void Start () {
	// 	offset = transform.position - player.transform.position;
	// }
	//
	// // Update is called once per frame
	// void Update () {
	//
	// }
	//
	// // LateUpdate is better for camera movement
	// // Late update is called after all other update functions are executed
	// // see docs at https://docs.unity3d.com/ScriptReference/MonoBehaviour.LateUpdate.html
	// void LateUpdate () {
	// 	transform.position = player.transform.position + offset;
	// }

	public GameObject player;
  public float cameraDistance = 10.0f;

  // Use this for initialization
  void Start () {
  }

  void LateUpdate ()
  {
      transform.position = player.transform.position - player.transform.forward * cameraDistance;
      transform.LookAt (player.transform.position);
      transform.position = new Vector3 (transform.position.x, transform.position.y + 5, transform.position.z);
  }
}
