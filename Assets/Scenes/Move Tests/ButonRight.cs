using UnityEngine;
using System.Collections;

public class ButonRight : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnMouseDown()
	{
		Player.VelX = 0.15f;
		Loyalty.VelX = 0.13f;
	}

	void OnMouseUp()
	{
		Player.VelX = 0f;
		Loyalty.VelX = 0f;
	}
}
