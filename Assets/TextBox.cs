using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets._2D;

public class TextBox : MonoBehaviour {

	public Texture[] faces;
	public int[] faceOrder;
	public string[] script;
	public GameObject character;

	public bool sign;

	RawImage face;
	Text text;
	int i;

	// Use this for initialization
	void Awake () {
		i = 1;
		face = gameObject.GetComponentInChildren<RawImage>();
		face.texture = faces [faceOrder [0]];
		text = gameObject.GetComponentInChildren<Text>();
		text.text = script [0];
		sign = true;
		gameObject.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
		if (i <faceOrder.Length) {
			if (Input.GetButtonDown ("Fire1") && gameObject.activeSelf && !sign) {
				face.texture = faces [faceOrder [i]];
				text.text = script [i];
				i++;
			}
			else if (Input.GetButtonDown ("Fire1") && gameObject.activeSelf && sign) {
				sign=false;
			}
		}
		else if(i==faceOrder.Length && (Input.GetButtonDown ("Fire1"))){
			face.texture=faces[faceOrder[0]];
			text.text=script[0];
			gameObject.SetActive(false);
			character.GetComponent<PlatformerCharacter2D>().canMove=true;
			i=0;
		}

	}

}
