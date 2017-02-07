using UnityEngine;
using System.Collections;

public class HintsDisplay : MonoBehaviour {

	GameObject hintsDisplay, directionDisplay;

	public void UpdateHints(string text){
		hintsDisplay = GameObject.Find ("Story Line");
		hintsDisplay.GetComponent<GUIText> ().text = text;
	}

	public void UpdateDirectionStatus(string text){
		directionDisplay = GameObject.Find ("Direction Text");
		directionDisplay.GetComponent<GUIText> ().text = text;
	}

}