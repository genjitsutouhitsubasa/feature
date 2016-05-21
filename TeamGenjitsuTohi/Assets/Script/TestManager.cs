using UnityEngine;
using System.Collections;

public class TestManager : MonoBehaviour {


	public int touchNum = 0;





	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.touchNum = Input.touchCount;
		foreach (Touch t in Input.touches) {
			Debug.Log ("id:" + t.fingerId + " pos:" + t.position);
		}

	}
}
