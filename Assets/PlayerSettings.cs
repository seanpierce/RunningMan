using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSettings : MonoBehaviour
{

	public GameObject player;
	public float cameraDistance = ViewSettings.Far;
	public int cameraHeight = 5;

	// Use this for initialization
	void Start()
	{
	}

	void OnGUI()
	{
		if (Event.current.Equals(Event.KeyboardEvent(KeyCode.V.ToString())))
			UpdateView();
	}

	// Update is called once per frame
	void Update()
	{
	}

	void LateUpdate()
	{
		TransformCamera();
	}

	void UpdateView()
	{
		if (cameraDistance == ViewSettings.Far)
		{
			cameraDistance = ViewSettings.Close;
			cameraHeight = 2;
			return;
		}

		if (cameraDistance == ViewSettings.Medium)
		{
			cameraDistance = ViewSettings.Far;
			cameraHeight = 5;
			return;
		}

		if (cameraDistance == ViewSettings.Close)
		{
			cameraDistance = ViewSettings.Medium;
			cameraHeight = 4;
			return;
		}

		print(cameraDistance);
	}

	void TransformCamera()
	{
		transform.position = player.transform.position - player.transform.forward * cameraDistance;
		transform.LookAt (player.transform.position);
		transform.position = new Vector3 (transform.position.x, transform.position.y + cameraHeight, transform.position.z);
	}
}

public static class ViewSettings
{
	public static float Far = 10.0f;
	public static float Medium = 6.0f;
	public static float Close = 3.0f;
}
