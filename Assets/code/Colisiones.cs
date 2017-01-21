using UnityEngine;
using System.Collections;

public class Colisiones : MonoBehaviour {

	void OnTriggerEnter (Collider col) 
    {
		if (col.CompareTag ("moneda")) {
			Destroy (col.gameObject);
		}
	}
}