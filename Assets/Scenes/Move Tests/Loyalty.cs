using UnityEngine;
using System.Collections;

public class Loyalty : MonoBehaviour 
{
	public static float VelX;
	public static float VelY;
	public static float VelZ;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(GeneralButtons.isPaused) return;
		transform.position += new Vector3 (VelX, VelY, VelZ);
	}
}
