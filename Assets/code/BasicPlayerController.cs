using UnityEngine;
using System.Collections;

public class BasicPlayerController : MonoBehaviour {
	
	public float m_speed;
	CharacterController m_CharacterController;

	void Start () {
		m_CharacterController = GetComponent<CharacterController>();
	}
	 
	void Update () {
		Vector3 l_Direction = Vector3.zero;
		float l_DesireAngle = transform.rotation.eulerAngles.y;
		bool l_NewAngle = false;

		if (Input.GetKey (KeyCode.RightArrow)) {
			l_Direction.x = 1.0f;
			l_NewAngle = true;
			l_DesireAngle = 90.0f;
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			l_Direction.x = -1.0f;
			l_NewAngle = true;
			l_DesireAngle = -90.0f;
		} else if (Input.GetKey (KeyCode.UpArrow)) {
			if (l_NewAngle) {
				if (l_DesireAngle == 90.0f)
					l_DesireAngle = 45.0f;
				if (l_DesireAngle == -90.0f)
					l_DesireAngle = -45.0f;
			} else {
				l_DesireAngle = 0.0f;
			}
			l_Direction.z = 1.0f;
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			if (l_NewAngle) {
				if (l_DesireAngle == -90.0f)
					l_DesireAngle = 225.0f;
				if (l_DesireAngle == 90.0f)
					l_DesireAngle = 135.0f;
			} else {
				l_DesireAngle = 180.0f;
			}

			l_Direction.z = -1.0f;
		}
		l_Direction.Normalize ();

		Vector3 l_Movement = l_Direction * m_speed * Time.deltaTime;
		m_CharacterController.Move (l_Movement);
		transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler (0.0f, l_DesireAngle, 0.0f),Mathf.Max(1.0f,Time.deltaTime/0.4f));
	}
}
