using UnityEngine;
using System.Collections;

public class IncorrectScene1 : MonoBehaviour {
	private Scene scene;

	// Use this for initialization
	void Start () {
		scene = new Scene("You have entered the wrong bus! Luckily the next stop is not too far but it is certain that you " + 
		                  "will be late to work. More importantly, your boss will not be glad about it. Now consider " +
		                  "a person with dyslexia, it must be even more difficult to follow the instruction. The next scene " +
		                  "will be the same situation, but in a dyslexic perspective.", "BusScene");
	}
	
	// Update is called once per frame
	void Update () {
		scene.SceneUpdate();
		scene.OnGUI("Dyslexia View");
	}
}
