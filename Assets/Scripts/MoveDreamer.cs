using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	private Transform trans;
	public float Velocity = 0.1f;
		
		void Start()
	{
		
		trans = GetComponent<Transform>();
		
	}
	
	void Update() 
	{
		
	}  
	
	void OnTriggerEnter2D(Collider2D other)
	{
		switch(other.gameObject.tag)
		{
		case "btnRight":
			
			trans.Translate(new Vector3(0.04f, -0, 0));

			
			
			Debug.Log ( "Indo Pra Direita");
				
			break;
		}
		
		switch(other.gameObject.tag)
		{
		case "btnLeft":
			
			
			trans.Translate(new Vector3(-0.04f, -0, 0));
			
			
			Debug.Log("Indo para a Esquerda");
			
			
			break;
		}
		
		switch(other.gameObject.tag)
		{
		case "btnDown":
			
			trans.Translate(new Vector3(0,-0.04f, 0));
			
			
			Debug.Log ( "Tô Abaixado");
			
			break;
			
		}
		
		switch(other.gameObject.tag)
			
		{
		case "btnUp":
			
			trans.Translate(new Vector3(0,0.04f,0));
			
			Debug.Log ("Olhei pra cima");
				
			break;
		}
		
	}
}
