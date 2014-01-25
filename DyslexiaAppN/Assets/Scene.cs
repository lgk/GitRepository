using UnityEngine;
using System.Collections;

public class Scene {
	public Rect scene;
	public Rect descriptionSize;
	public Rect button;

	public string desciption;
	public string nextScene;
	public string buttonName;

	public bool correct;

	// Update is called once per frame
	public Scene(string desc, string next)
	{
		scene = new Rect(0, 0, Screen.width, Screen.height);

		descriptionSize = new Rect(Screen.width/12, Screen.height/8,  Screen.width*10/12, Screen.height*3/5);
		
		button = new Rect(Screen.width*4/9, descriptionSize.y + descriptionSize.height, Screen.width/9, Screen.height/8);

		desciption = desc;

		nextScene = next;
	}

	public void SceneUpdate () {

		scene = new Rect(0, 0, Screen.width, Screen.height);
		
		descriptionSize = new Rect(Screen.width/12, Screen.height/8,  Screen.width*10/12, Screen.height*3/5);
		
		button = new Rect(Screen.width*4/9, descriptionSize.y + descriptionSize.height, Screen.width/9, Screen.height/8);
	}
	public void OnGUI(string btnName)
	{
		scene = new Rect(0, 0, Screen.width, Screen.height);
		
		//descriptionSize = new Rect(Screen.width/12, Screen.height/8,  Screen.width*10/12, Screen.height*3/5);
		
		button = new Rect(Screen.width*4/9, descriptionSize.y + descriptionSize.height, Screen.width/9, Screen.height/8);


		GUI.contentColor = Color.black;

		GUI.Box(scene, "");

		GUI.skin.label.fontSize = 28;
		GUI.skin.label.wordWrap = true;
		GUI.Label(descriptionSize, desciption);

		GUI.skin.button.fontSize = 28;

		buttonName = btnName;

		if(GUI.Button(button, buttonName))
		{
			Application.LoadLevel(nextScene);
		}
	}
}
