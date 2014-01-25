using UnityEngine;
using System.Collections;

public class CorrectScene1 : MonoBehaviour {
	private Scene scene;

	// Use this for initialization
	void Start () {
		scene = new Scene("You have entered the correct bus, but is it the same for a person with dyslexia? The next scene " +
		                  "will be the same situation, but in a dyslexic perspective.", "BusScene");
	}
	
	// Update is called once per frame
	void Update () {
		scene.SceneUpdate();
		scene.OnGUI("Dyslexia View");
	}
}
