﻿// Example from youtube
// https://www.youtube.com/watch?v=blO039OzUZc&t=1161s

using UnityEngine;
using System.Collections;

public class FP_CameraController : MonoBehaviour {

	Vector2 mouseLook;
	Vector2 smoothV;
	public float sensitivity = 5.0f;
	public float smoothing = 2.0f;

	GameObject character;

	void Start () {
		character = this.transform.parent.gameObject;
	}

	void Update () {
		var md = new Vector2 (Input.GetAxisRaw ("Mouse X"), Input.GetAxisRaw ("Mouse Y"));

		md = Vector2.Scale (md, new Vector2 (sensitivity * smoothing, sensitivity * smoothing));
		smoothV.x = Mathf.Lerp (smoothV.x, md.x, 1f / smoothing);
		//smoothV.y = Mathf.Lerp (smoothV.y, md.y, 1f / smoothing);
		mouseLook.y = Mathf.Clamp (mouseLook.y, -25f, 25f);
		mouseLook += smoothV;

		transform.localRotation = Quaternion.AngleAxis (-mouseLook.y, Vector3.right);
		character.transform.localRotation = Quaternion.AngleAxis (mouseLook.x, character.transform.up);
		//character.transform.localRotation = Quaternion.AngleAxis (-mouseLook.y, Vector3.right);
	}
}
