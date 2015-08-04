using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets._2D;

public class TriggerConversation : MonoBehaviour {
	public GameObject textBox;
	private GameObject character;
	public GameObject[] characters;
	int i;

	void Start(){
		i = 0;
		character = characters [0];
	}

	void Update(){
		if (Input.GetButtonDown ("Fire2")) {
			if(characters.Length == 0)
				return;
			if (i == characters.Length - 1)
				i = 0;
			else
				i++;
		
			character = characters [i];
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if (col.tag == "Player") {
			if (Input.GetButtonDown ("Fire1") && col.gameObject.GetComponent<PlatformerCharacter2D> ().canMove && i == 0) {
				character.GetComponent<PlatformerCharacter2D> ().canMove = false;
				textBox.SetActive (true);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Player") {
			if (Input.GetButtonDown ("Fire1") && col.gameObject.GetComponent<PlatformerCharacter2D> ().canMove && i == 0) {
				character.GetComponent<PlatformerCharacter2D> ().canMove = false;
				textBox.SetActive (true);
			}
		}
	}
	
}
