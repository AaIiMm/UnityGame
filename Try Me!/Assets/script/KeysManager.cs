using UnityEngine;
using System.Collections;

public class KeysManager : MonoBehaviour {
	
	public int KeysNbr = 0;

	public GameObject Keys;
	public GameObject KeysMaterial;
	void OnTriggerEnter(Collider other) {
		
		if (other.gameObject.tag == "Player") {
			Destroy (KeysMaterial);
			Destroy (Keys.GetComponent<Collider>());
			PlayerController.Keys = PlayerController.Keys + 1;
			Debug.Log (KeysNbr);


		}
	}
}