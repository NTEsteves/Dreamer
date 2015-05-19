using UnityEngine;
using System.Collections;

public class Enemy: MonoBehaviour 
{
	
	public float VelX;
	public float VelY;
	public float VelZ;
	
	void Start () 
	{
		//VelX = -0.02f;
		//VelY = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{	
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
		}
	}


}

