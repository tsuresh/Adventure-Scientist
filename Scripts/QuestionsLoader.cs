using UnityEngine;
using System.Collections;

public class QuestionsLoader : MonoBehaviour {

	GameObject quizTexture, quizQuestion, quizAnswers;
	Questions qs;

	public void DisplayQuestion(int id){
		quizTexture = GameObject.Find ("Texture");
		quizQuestion = GameObject.Find ("Question");
		quizAnswers = GameObject.Find ("Answers");
		qs = new Questions ();

		quizQuestion.GetComponent<GUIText> ().text = qs.questions[id-1];
		string answerList = "1. "+qs.answers[id-1,0]+"\n\r2. "+qs.answers[id-1,1]+"\n\r3. "+qs.answers[id-1,2];
		quizAnswers.GetComponent<GUIText> ().text = answerList;

		quizTexture.GetComponent<GUITexture> ().enabled = true;
		quizQuestion.GetComponent<GUIText> ().enabled = true;
		quizAnswers.GetComponent<GUIText> ().enabled = true;
		Debug.Log (id-1);
	}

	public void HideQuestion(){
		quizTexture = GameObject.Find ("Texture");
		quizQuestion = GameObject.Find ("Question");
		quizAnswers = GameObject.Find ("Answers");

		quizTexture.GetComponent<GUITexture> ().enabled = false;
		quizQuestion.GetComponent<GUIText> ().enabled = false;
		quizAnswers.GetComponent<GUIText> ().enabled = false;
	}
}