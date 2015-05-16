using UnityEngine;
using System.Collections;

public class MoveDreamer : MonoBehaviour {
	
	private Transform trans;
	public float Velocity = 0.1f;
		
		void Start()
	{
		
		trans = GetComponent<Transform>();
		
	}
	
	void Update() 
	{

	}  
	
		private string move()
	{
		if(Input.GetKey(KeyCode.DownArrow)){
			trans.Translate(new Vector3(-0,-0.04f, 0));
			return "DOWN";
		}else if(Input.GetKey(KeyCode.UpArrow)){
			trans.Translate(new Vector3(0f, 0.04f, 0));
			return "UP";
		}else if(Input.GetKey(KeyCode.LeftArrow)){
			trans.Translate(new Vector3(-0.04f, 0, 0));
			return "LEFT";
		}else if(Input.GetKey(KeyCode.RightArrow)){
			trans.Translate(new Vector3(0.04f, -0, 0));
			return "RIGHT";
		}else{
			return "IDLE";
		}	
	}
}