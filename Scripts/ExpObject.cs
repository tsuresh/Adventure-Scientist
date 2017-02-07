using UnityEngine;
using System.Collections;

public class ExpObject : MonoBehaviour {

	string tag, objname;
	static int gotobjects = 0;
	static string session = "exp1";
	GameObject expobject, test_tube_plane, leaf, leaf_plane;
	HintsDisplay hd;
	Questions qs;
	Clickable cl;
	
	void Start () {
		tag = gameObject.tag;
		objname = "exp-"+gameObject.name;

		expobject = GameObject.Find (objname);
		test_tube_plane = GameObject.Find ("exp-test_tube_plane");
		leaf = GameObject.Find ("exp-leaf");
		leaf_plane = GameObject.Find ("exp-leaf_plane");

		hd = new HintsDisplay ();
		qs = new Questions ();
		cl = new Clickable ();
	}

	void OnMouseDown(){
		Debug.Log (objname);
		
		if(gotobjects <= 4){
			if(tag == "exp-1"){
				expobject.GetComponent<SpriteRenderer>().enabled = true;
			}
			if(gotobjects == 4){
				cl.AddScore();
				cl.SkipQuestion(21);
			}
		}

		if(gameObject.name == "exp-test_tube"){
			test_tube_plane.GetComponent<SpriteRenderer>().enabled = true;
			leaf.GetComponent<SpriteRenderer>().enabled = false;
			leaf_plane.GetComponent<SpriteRenderer>().enabled = true;
			cl.SkipQuestion(2);
		} else {
			gotobjects = gotobjects+1;
		}
		Destroy (gameObject);

	}
	
}
