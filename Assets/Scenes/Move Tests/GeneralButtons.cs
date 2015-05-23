using UnityEngine;
using System.Collections;

public class GeneralButtons : MonoBehaviour 
{
	public static bool isPaused;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(GeneralButtons.isPaused) return;
	}

	void OnMouseDown()
	{
		if (this.gameObject.tag == "Pause") 
		{
			GeneralButtons.isPaused = !GeneralButtons.isPaused;
			Debug.Log("Pause");
		}
	}
	

}
