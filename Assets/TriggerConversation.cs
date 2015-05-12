using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets._2D;

public class TriggerConversation : MonoBehaviour {
	public GameObject textBox;
	public GameObject character;
	void OnTriggerStay2D(Collider2D col){
		if (Input.GetButtonDown ("Fire1")) {
			character.GetComponent<PlatformerCharacter2D> ().canMove = false;
			textBox.SetActive (true);
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if (Input.GetButtonDown ("Fire1")) {
			character.GetComponent<PlatformerCharacter2D> ().canMove = false;
			textBox.SetActive (true);
		}
	}
	
}
