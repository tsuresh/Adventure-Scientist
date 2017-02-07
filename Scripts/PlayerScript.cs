using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float speed = 3.0f;
	public string axisName = "Horizontal";
	public Animator anim;
	
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
	}

	void FixedUpdate () {

		anim.SetFloat("speed", Mathf.Abs(Input.GetAxis(axisName)));

		if (Input.GetAxis (axisName) > 0){

			Vector3 scale = transform.localScale;
			scale.x = 1;
			transform.localScale = scale;

			transform.Translate(Vector3.right * speed * Time.deltaTime);
				
		} else if(Input.GetAxis (axisName) < 0){

			Vector3 scale = transform.localScale;
			scale.x = -1;
			transform.localScale = scale;

			transform.Translate(Vector3.left * speed * Time.deltaTime);
				
		}
		
	}
	
}