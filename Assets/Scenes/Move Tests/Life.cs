using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour 

{
	

	
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{	

	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		switch(other.gameObject.tag)
		{
		case "JumpLeft":
			
			Enemy.VelX = -0.15f;
			Enemy.VelY = 0.84f;
			Debug.Log ("Bateu");
			
			break;
		}
		switch(other.gameObject.tag)
		{
		case "JumpRight":

			Enemy.VelX = 0.15f;
			Enemy.VelY = 0.84f;
			Debug.Log ("Bateu");
			
			break;
		}/*
		
		switch(other.gameObject.tag)
		{
		case "Wall3":
			
			VelX = -0.15f;
			VelY = -0.10f;
			Debug.Log ("Bateu");
			
			break;
		}
		
		switch(other.gameObject.tag)
		{
		case "Wall4":
			
			VelX = 0.15f;
			VelY = 0.10f;
			Debug.Log ("Bateu");
			
			break;
		}
		
		switch(other.gameObject.tag)
		{
		case "Wall5":
			
			VelX = -0.15f;
			VelY = 0.10f;
			Debug.Log ("Bateu");
			
			break;
		}*/
	}
	
	
}
