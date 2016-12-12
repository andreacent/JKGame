using UnityEngine;
using System.Collections;

public class Colisiones : MonoBehaviour {

	void OnTriggerEnter (Collider col) 
    {
		if (col.CompareTag ("moneda")) {
			Destroy (col.gameObject);
		}
		if (col.CompareTag ("moneda1")) {
			Destroy (col.gameObject);
		}
		if (col.CompareTag ("moneda2")) {
			Destroy (col.gameObject);
		}
		if (col.CompareTag ("moneda3")) {
			Destroy (col.gameObject);
		}
		if (col.CompareTag ("moneda4")) {
			Destroy (col.gameObject);
		}
		if (col.CompareTag ("moneda5")) {
			Destroy (col.gameObject);
		}

	}
}