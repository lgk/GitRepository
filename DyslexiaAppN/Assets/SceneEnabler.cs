using UnityEngine;
using System.Collections;

public class SceneEnabler : MonoBehaviour {
	public static bool correct;
	private MonoBehaviour scene;

	// Use this for initialization
	void Start () {
		if(correct = true)
		{
			scene = GetComponent<CorrectScene1>();
			scene.enabled = true;
		}
		else
		{
			scene = GetComponent<IncorrectScene1>();
			scene.enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnDisable()
	{
		scene.enabled = false;
	}
}
