// by @torahhorse

using UnityEngine;
using System.Collections;

// allows player to zoom in the FOV when holding a button down
[RequireComponent (typeof (Camera))]
public class CameraZoom : MonoBehaviour
{
	public float zoomFOV = 30.0f;
	public float zoomSpeed = 9f;
	
	private float targetFOV;
	private float baseFOV;

	public GameObject zoomCamera;

	public zoomColorDetect zoomSwitch;
	
	void Start ()
	{
		SetBaseFOV(GetComponent<Camera>().fieldOfView);
	}
	
	void Update ()
	{
		//you cant zoom till you have the camera
		if (globalVarStorage.hasCamera == true)
		{
			if (Input.GetButton("Fire2"))
			{
				targetFOV = zoomFOV;
				//Debug.Log("test");
				zoomSwitch.ZoomSwitchRed(); //see red items when zoom
				zoomCamera.SetActive(true); //turn on camera on egg so you can see it in mirrors
			}
			else
			{
				targetFOV = baseFOV;
				zoomSwitch.ZoomSwitchBW(); //turn off red items and black and white items turn on 
				zoomCamera.SetActive(false); //turn off zoomCamera
			}

			UpdateZoom();
		}
	}
	
	private void UpdateZoom()
	{
		GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, targetFOV, zoomSpeed * Time.deltaTime);
	}
	
	public void SetBaseFOV(float fov)
	{
		baseFOV = fov;
	}
}
