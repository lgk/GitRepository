using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Rect boardButton;

	private string busName;

	private bool correct;

	private float targetPosX;
	private float targetPosZ;
	// Use this for initialization
	void Start () {
		correct = false;
		//Camera.main.backgroundColor = Color.blue;
	}
	
	// Update is called once per frame
	void Update () {
		boardButton = new Rect(Screen.width*7/9, Screen.height*7/8, 
		                       Screen.width*3/18, Screen.height/8);

		if(transform.position.z >= 0)
		{
			if(transform.position.x >= 5)
			{
				busName = "1a";

//				targetPosX = 8;
//				targetPosZ = 8;
			}
			else if(transform.position.x <= -3)
			{
				busName = "6B";

//				targetPosX = -9;
//				targetPosZ = 9;
			}
			else
			{
				busName = "6a";

//				targetPosX = 0;
//				targetPosZ = 8;
			}
		}
		else
		{
			if(transform.position.x >= 5)
			{
				busName = "2c";

//				targetPosX = 8;
//				targetPosZ = -8;
			}
			else if(transform.position.x <= -3)
			{
				busName = "9B";

//				targetPosX = -9;
//				targetPosZ = -9;
			}
			else
			{
				busName = "9b";

//				targetPosX = 0;
//				targetPosZ = -8;
			}
		}
	}
	void OnGUI()
	{
//		CorrectScene1 correctScene1 = new CorrectScene1();
//		IncorrectScene1 incorrectScene1 = new IncorrectScene1();

		GUI.skin.button.fontSize = 14;

		if(GUI.Button(boardButton, "Board Bus" + busName))
		{
			//iTween.MoveTo(gameObject, iTween.Hash("x", targetPosX, "z", targetPosZ, "time", 2, "oncomplete", "AnswerScene"));
			//SceneEnabler sceneEnabler = gameObject.GetComponent<SceneEnabler>();

			if(busName == "6B")
			{
				SceneEnabler.correct = true;
				//CorrectScene1 correctScene1 = new CorrectScene1();
//				gameObject.AddComponent<ScriptableObject>("CorrectScene1");
//				correctScene1.enabled = true;
			}
			else
			{
			//	IncorrectScene1 incorrectScene1 = new IncorrectScene1();
				SceneEnabler.correct = false;
			//	incorrectScene1.enabled = true;
			}
			Application.LoadLevel("Scene");
		}
	}
}
