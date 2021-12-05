using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LightSetup();
		CameraSetup();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void CameraSetup()
    {
		Debug.Log("Camera Setup	done");
		GameObject mainCamera = GameObject.FindGameObjectWithTag("MainCamera");

		//Camera Transform
		mainCamera.transform.position = new Vector3(0f, 0f, -300f);
		mainCamera.transform.eulerAngles = new Vector3(0f, 0f, 0f);

		//camera background

		mainCamera.GetComponent<Camera>().clearFlags = CameraClearFlags.SolidColor;
		mainCamera.GetComponent<Camera>().backgroundColor = new Color32(0, 0, 0, 255);

	}

	private void LightSetup()
    {
		GameObject dirLight = GameObject.Find("Directional Light");
		dirLight.transform.eulerAngles = new Vector3(50, -30, 0);
		dirLight.GetComponent<Light>().color =
		new Color32(152, 204, 255, 255);
	}
}
