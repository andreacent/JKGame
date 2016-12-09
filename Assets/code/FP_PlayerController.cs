using UnityEngine;
using System.Collections;

public class FP_PlayerController : MonoBehaviour {
	
	public float speed = 0.3f;
	CharacterController m_CharacterController;

	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
	}
	 
	void Update () {

		Vector3 direction = Vector3.zero;

		float translation = Input.GetAxis ("Vertical") * speed;
		float straffe = Input.GetAxis ("Horizontal") * speed;
		translation *= Time.deltaTime;
		straffe *= Time.deltaTime;

		if (Input.GetKey ("e"))
       		direction.y = 1.0f;
       	if (Input.GetKey ("x"))
       		direction.y = -1.0f;

       	Vector3 movement = direction * speed * Time.deltaTime;
		transform.Translate (straffe, movement.y, translation);

		if (Input.GetKeyDown ("escape"))
			Cursor.lockState = CursorLockMode.None;
	}
}