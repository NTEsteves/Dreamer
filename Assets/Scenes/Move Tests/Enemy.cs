using UnityEngine;
using System.Collections;

public class Enemy: MonoBehaviour 
{
	
	public static float VelX = -0.15f;
	public static float VelY = 0f;
	public static float VelZ;
	
	void Start () 
	{
		VelX = -0.15f;
		VelY = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{	
		if(GeneralButtons.isPaused) return;
		transform.position += new Vector3(VelX,VelY, VelZ);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		switch(other.gameObject.tag)
		{
		case "WallRight":

			VelX = -0.15f;
			VelY = 0.5f;
			Debug.Log ("Bateu");

		break;
		}
		switch(other.gameObject.tag)
		{
		case "WallLeft":
			
			VelX = 0.10f;
			VelY = 0;
			Debug.Log ("Bateu");
			
			break;
		}

		switch(other.gameObject.tag)
		{
		case "WallVision":
			
			VelX = -0.15f;
			VelY = -0.10f;
			Debug.Log ("Bateu");
			
			break;
		}

		switch(other.gameObject.tag)
		{
		case "Player":
			
			VelX = -0.5f;
			VelY = 0f;
			Debug.Log ("Bateu");
			
			break;
		}

		switch(other.gameObject.tag)
		{
		case "Player2":
			
			VelX = 0.5f;
			VelY = 0f;
			Debug.Log ("Bateu");
			
			break;
		}
	}


}

