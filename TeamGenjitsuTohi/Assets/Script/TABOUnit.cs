using UnityEngine;
using System.Collections;

public class TABOUnit : MonoBehaviour {


	private Vector2 frontPos;
	private Vector2 leftPos;
	private Vector2 rightPos;

	private int frontId;
	private int leftId;
	private int rightId;


	public void SetTABOPoint(int fId, int lId, int rId)
	{
		this.frontId = fId;
		this.leftId = lId;
		this.rightId = rId;


	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.frontPos = Input.GetTouch (this.frontId).position;
		this.leftPos = Input.GetTouch (this.leftId).position;
		this.rightPos = Input.GetTouch (this.rightId).position;

	}
}
