using UnityEngine;
using System.Collections;

public class Bus : MonoBehaviour {
	public float waitSecond;
	public float moveSecond;

	private bool waited;
//	public bool income;

//	public GameObject smallBus;

	private float positionZ;
	public float moveAmount;

	public bool income;

	// Use this for initialization
	void Start () {

		StartCoroutine("Wait");
	}
	
	// Update is called once per frame
	void Update () 
	{

		//StartCoroutine("Wait");

//		if(waited == true && income == true)
//		{
//			waited = false;
//			Debug.Log (gameObject + "waited is false");
//
//			CreateBus();
//
////			if(firstBusArrived == false)
////			{
////				stopPositionZ = -8;
//////				if (smallBus.transform.position.z > -8)
//////				{
////
//////					Debug.Log("incoming");
//////					smallBus.transform.position.z --;
//////				}
//////				else
//////				{
//////					arrived = true;
//////				}
////			}
////			else
////			{
////				stopPositionZ = 8;
////
////				stopSpawn = true;
//////				if (smallBus.transform.position.z > 8)
//////				{
//////					Debug.Log("incoming");
//////					smallBus.transform.position.z --;
//////				}
//////				else
//////				{
//////					arrived = true;
//////				}
////			}
//			Move();
//		}

		if(waited == true)
		{
			waited = false;

			//stopPositionZ = -20;
			Move();
		}

		if(gameObject.transform.position.z <= -25)
			Destroy(gameObject);
	}

//	public void CreateBus()
//	{
//		Instantiate(gameObject, new Vector3(0, 2, 25), gameObject.transform.rotation);
//		Debug.Log (gameObject + " created, its z position is " + smallBus.transform.position.z);
//	}

	public void Move()
	{
		if(income == false)
		{
			iTween.MoveAdd(gameObject,iTween.Hash("amount", new Vector3(0, 0, moveAmount), "time", moveSecond, "easetype", "easeInQuad"));
		}
		else
		{
			iTween.MoveAdd(gameObject,iTween.Hash("amount", new Vector3(0, 0, moveAmount), "time", moveSecond, "easetype", "easeOutQuad"));
		}
		Debug.Log(gameObject + "moved");
	}
	IEnumerator Wait()
	{    
		yield return new WaitForSeconds(waitSecond);
		waited = true;
	}
}

