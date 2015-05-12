using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets._2D;

public class AreaConversation : MonoBehaviour {
	public GameObject textBox;
	public GameObject character;
	void OnTriggerEnter2D(Collider2D col){
			character.GetComponent<PlatformerCharacter2D> ().canMove = false;
			textBox.GetComponent<TextBox>().sign=false;
			textBox.SetActive (true);
			Destroy (gameObject);
	}
}
