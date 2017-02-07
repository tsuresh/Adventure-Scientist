using UnityEngine;
using System.Collections;

public class Clickable : MonoBehaviour {
	
	//CODED BY, SURESH MICHAEL PEIRIS OF S. THOMAS' COLLEGE MOUNT LAVINIA
	//TSMPMAIL@GMAIL.COM
	//HTTP://SURESHMICHAEL.TK

	public int objectID;
	public int startFrom = 1;
	public static int currentQuestion = 1;
	public static bool isActiveQuestion = false;

	public bool isExperiment = false;
	public bool isAlreadyAnswered = false;

	private int correctAnswer;
	public static int score = 0;
	HintsDisplay hd;
	Questions qs;
	QuestionsLoader ql;
	GameObject scoreDisp, test_tube_plane, leaf, leaf_plane, leaf_experimented, chem_bottle, arrows, new_arrow, old_arrow;
	private bool arrowEnabled = true;

	string tag, objname;
	static int gotobjects = 0;

	AudioClip wrongsound;
	
	void Start () {

		score = 0;
		currentQuestion = 1;
		gotobjects = 0;

		if(gameObject.name != "exp-test_tube"){
			objectID = int.Parse(gameObject.tag);
		}

		hd = new HintsDisplay ();
		qs = new Questions ();
		ql = new QuestionsLoader ();
		scoreDisp = GameObject.Find ("Scores");
		hd.UpdateHints((qs.hints[(currentQuestion + startFrom) - 2]));
		test_tube_plane = GameObject.Find ("exp-test_tube_plane");
		leaf_experimented = GameObject.Find ("exp-leaf_experimented");
		chem_bottle = GameObject.Find ("exp-chem_bottle");
		leaf = GameObject.Find ("exp-leaf");
		leaf_plane = GameObject.Find ("exp-leaf_plane");
		arrows = GameObject.Find ("Arrows");
		wrongsound = Resources.Load ("sound/wrong_answer") as AudioClip;
		if(arrows != false){
			arrowEnabled = true;
		} else {
			arrowEnabled = false;
		}
	}

	void Update(){
		if(isActiveQuestion != false){
			if(Input.GetKeyDown(KeyCode.Keypad1)){
				CheckAnswer(1);
				isActiveQuestion = false;
				isAlreadyAnswered = true;
				currentQuestion ++;
			} else if(Input.GetKeyDown(KeyCode.Keypad2)){
				CheckAnswer(2);
				isActiveQuestion = false;
				isAlreadyAnswered = true;
				currentQuestion ++;
			} else if(Input.GetKeyDown(KeyCode.Keypad3)){
				CheckAnswer(3);
				isActiveQuestion = false;
				isAlreadyAnswered = true;
				currentQuestion ++;
			}
		}
	}

	void FixedUpdate(){
		scoreDisp.GetComponent<GUIText> ().text = score.ToString ();
	}

	void OnMouseDown(){
		Debug.Log (objectID + " " + ((currentQuestion + startFrom)-1));

		if(gameObject.GetComponent<BoxCollider2D>().isTrigger == false){
			gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
		}

		if(gameObject.name == "exp-test_tube" && currentQuestion == 4){
			test_tube_plane.GetComponent<SpriteRenderer>().enabled = true;
			leaf.GetComponent<SpriteRenderer>().enabled = false;
			leaf_plane.GetComponent<SpriteRenderer>().enabled = true;
			hd.UpdateHints(qs.hints[(currentQuestion + startFrom)-1]);
			currentQuestion ++;
			Destroy(gameObject);
		} else if(gameObject.name == "exp-leaf_plane" && currentQuestion == 6){
			Debug.Log(currentQuestion);
			hd.UpdateHints(qs.hints[(currentQuestion + startFrom)-1]);
			leaf_experimented.GetComponent<SpriteRenderer>().enabled = true;
			chem_bottle.GetComponent<SpriteRenderer>().enabled = true;
			currentQuestion++;
			Destroy(gameObject);
		} else if(objectID == ((currentQuestion + startFrom)-1) && isActiveQuestion != true){
			isActiveQuestion = true;
			ql.DisplayQuestion(((currentQuestion + startFrom) - 1));
			audio.Play();
		}
	}

	void CheckAnswer(int givenAnswer){

		Debug.Log (qs.correctAnswers[(currentQuestion + startFrom)-2] + " " + (givenAnswer-1));

		if(qs.correctAnswers[(currentQuestion + startFrom)-2] == givenAnswer-1){
			hd.UpdateDirectionStatus("Answer is Correct!");
			score = score + 100;
		} else {
			hd.UpdateDirectionStatus("OPS! That was incorrect. Be careful!");
			audio.clip = wrongsound;
			audio.Play();
		}

		if(currentQuestion < 10){
			hd.UpdateHints(qs.hints[(currentQuestion + startFrom)-1]);
		} else {
			if(score >= 600){

				if(Application.loadedLevelName == "level1"){
					Application.LoadLevel("level1-success");
				} else if(Application.loadedLevelName == "level2"){
					Application.LoadLevel("level2-success");
				} else if(Application.loadedLevelName == "level3"){
					Application.LoadLevel("level3-success");
				}

			} else {
				if(Application.loadedLevelName == "level1"){
					Application.LoadLevel("level1-unsuccess");
				} else if(Application.loadedLevelName == "level2"){
					Application.LoadLevel("level2-unsuccess");
				} else if(Application.loadedLevelName == "level3"){
					Application.LoadLevel("level3-unsuccess");
				}
			}
		}

		if(arrowEnabled == true){
			//Show the new arrow
			int new_arrow_id = currentQuestion + startFrom;
			if(new_arrow = GameObject.Find ("arrow-" + new_arrow_id.ToString())){
				new_arrow.GetComponent<SpriteRenderer> ().enabled = true;
			}

			//Hide old arrow
			int old_arrow_id = ((currentQuestion+startFrom)-1);
			if(old_arrow = GameObject.Find("arrow-" + old_arrow_id.ToString())){
				old_arrow.GetComponent<SpriteRenderer>().enabled = false;
			}
		}

		ql.HideQuestion ();
	}

	public void SkipQuestion(int startFrom){
		HintsDisplay hd = new HintsDisplay ();
		Questions qs = new Questions ();
		hd.UpdateHints(qs.hints[(currentQuestion + startFrom)-1]);
		currentQuestion ++;
	}

	public void AddScore(){
		score = + 100;
	}
	
}