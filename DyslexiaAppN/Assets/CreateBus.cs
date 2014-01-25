using UnityEngine;
using System.Collections;

public class CreateBus : MonoBehaviour {
	public float waitSecond;
	private bool waited;

	public GameObject smallBus;

	void Start(){
		StartCoroutine("Wait");
	}
	
	// Update is called once per frame
	void Update () {
		if(waited == true)
		{
			waited = false;

			Instantiate(smallBus, new Vector3(0, 2, 25), gameObject.transform.rotation);
			Debug.Log (smallBus + " created, its z position is " + smallBus.transform.position.z);
		}
	}
	IEnumerator Wait()
	{    
		yield return new WaitForSeconds(waitSecond);
		waited = true;
	}
}
