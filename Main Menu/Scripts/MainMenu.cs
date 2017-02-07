using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	
	public Sprite hoverObject;
	private Sprite originalObject;
	GameObject ins_overlay, ins_heading, ins_desc, ins_close;
	bool isHoverVisible = true;

	void Start(){
		ins_heading = GameObject.Find ("ins_heading");
		ins_desc = GameObject.Find ("ins_desc");
		ins_overlay = GameObject.Find ("ins_overlay");
		ins_close = GameObject.Find ("ins_close");
	}

	void OnMouseEnter(){
		originalObject = gameObject.GetComponent<SpriteRenderer> ().sprite;
		gameObject.GetComponent<SpriteRenderer> ().sprite = hoverObject;
	}
	
	void OnMouseExit(){
		gameObject.GetComponent<SpriteRenderer> ().sprite = originalObject;
	}
	
	void OnMouseDown(){
		if(gameObject.name == "play"){
			Application.LoadLevel("level1");
		} else if(gameObject.name == "next1"){
			Application.LoadLevel("level2");
		} else if(gameObject.name == "backmenu"){
			Application.LoadLevel("menu");
		} else if(gameObject.name == "next2"){
			Application.LoadLevel("level3");
		} else if(gameObject.name == "ins"){
			ins_overlay.GetComponent<GUITexture>().enabled = true;
			ins_heading.GetComponent<GUIText>().enabled = true;
			ins_desc.GetComponent<GUIText>().enabled = true;
			ins_close.GetComponent<GUIText>().enabled = true;
		} else if(gameObject.name == "ins_close"){
			ins_overlay.GetComponent<GUITexture>().enabled = false;
			ins_heading.GetComponent<GUIText>().enabled = false;
			ins_desc.GetComponent<GUIText>().enabled = false;
			ins_close.GetComponent<GUIText>().enabled = false;
		} else if(gameObject.name == "playagain1"){
			Application.LoadLevel("level1");
		} else if(gameObject.name == "playagain2"){
			Application.LoadLevel("level2");
		} else if(gameObject.name == "playagain3"){
			Application.LoadLevel("level3");
		}
 	}
	
}