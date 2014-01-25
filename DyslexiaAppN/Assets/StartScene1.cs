using UnityEngine;
using System.Collections;

public class StartScene1 : MonoBehaviour{
	private Scene scene;

	// Use this for initialization
	void Start () {
		scene = new Scene("It is Monday morning and you are ready to go to work. " +
		                  "As usual you arrive at the bus station 10 minutes early to make sure that " +
		                  "you can get on the bus on time, although your colleagues think it is " +
		                  "unnecessary. You wait at the '1a' bus stand as usual and look at the " +
		                  "noticeboard...", "BusScene");

//		desciption = "It is Monday morning and you are ready to go to work. " +
//			"As usual you arrive at the bus station 10 minutes early to make sure that " +
//				"you can get on the bus on time, although your colleagues think it is " +
//				"unnecessary. You wait at the '1a' bus stand as usual and look at the " +
//				"noticeboard...";
//		nextScene = "BusScene";
	}
	
	// Update is called once per frame
	void Update () {
		scene.SceneUpdate();
		//scene.OnGUI("Start");
	}
	void OnGUI()
	{
		scene.OnGUI("Start");
	}
}
