using UnityEngine;
using System.Collections;

public class ButtonUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnMouseDown()
	{
		
		Player.VelY = 0.15f;
		Loyalty.VelY = 0.13f; 
	}
	
	void OnMouseUp()
	{
		Player.VelY = 0f;
		Loyalty.VelY = 0f;
	}
}
