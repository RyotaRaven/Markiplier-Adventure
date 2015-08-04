using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets._2D;

public class AreaConversation : MonoBehaviour {
	public GameObject textBox;
	public GameObject character;
	public GameObject[] characters;
	int i;
	
	void Start(){
		i = 0;
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

	void OnTriggerEnter2D(Collider2D col){
		if (i == 0) {
			character.GetComponent<PlatformerCharacter2D> ().canMove = false;
			textBox.GetComponent<TextBox> ().sign = false;
			textBox.SetActive (true);
			Destroy (gameObject);
		}
	}
}
