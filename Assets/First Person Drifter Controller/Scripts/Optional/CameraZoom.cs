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
		//if (globalVarStorage.hasCamera == true)
		//{
			if (Input.GetButton("Fire2"))
			{
				targetFOV = zoomFOV;
				//Debug.Log("test");
				zoomSwitch.ZoomSwitchRed();
				zoomCamera.SetActive(true);
			}
			else
			{
				targetFOV = baseFOV;
				zoomSwitch.ZoomSwitchBW();
				zoomCamera.SetActive(false);
			}

			UpdateZoom();
		//}
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
