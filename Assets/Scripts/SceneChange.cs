using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

public class SceneChange : MonoBehaviour 
{
	public List<string> Scenes;
	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Application.loadedLevel == 0)
			Debug.Log ("Teste" + Application.loadedLevel);

		if (Application.loadedLevel == 0 && Input.GetKey(KeyCode.S))//Caso eu esteja na scene Menu, e aperte S de START
			Application.LoadLevel(Scenes[1]);//Carrega a StartCutscene
		if (Application.loadedLevel == 1 && Input.GetKey(KeyCode.S))//Caso eu esteja na scene Menu, e aperte S de START
			Application.LoadLevel(Scenes[2]);//Carrega a StartCutscene
		if (Application.loadedLevel == 2 && Input.GetKey(KeyCode.S))//Caso eu esteja na scene Menu, e aperte S de START
			Application.LoadLevel(Scenes[3]);//Carrega a StartCutscene
		if (Application.loadedLevel == 3 && Input.GetKey(KeyCode.S))//Caso eu esteja na scene Menu, e aperte S de START
			Application.LoadLevel(Scenes[4]);//Carrega a StartCutscene
		if (Application.loadedLevel == 4 && Input.GetKey(KeyCode.S))//Caso eu esteja na scene Menu, e aperte S de START
			Application.LoadLevel(Scenes[5]);//Carrega a StartCutscene
		if (Application.loadedLevel == 5 && Input.GetKey(KeyCode.S))//Caso eu esteja na scene Menu, e aperte S de START
			Application.LoadLevel(Scenes[6]);//Carrega a StartCutscene
		if (Application.loadedLevel == 6 && Input.GetKey(KeyCode.S))//Caso eu esteja na scene Menu, e aperte S de START
			Application.LoadLevel(Scenes[7]);//Carrega a StartCutscene
		if (Application.loadedLevel == 7 && Input.GetKey(KeyCode.S))//Caso eu esteja na scene Menu, e aperte S de START
			Application.LoadLevel(Scenes[8]);//Carrega a StartCutscene
		if (Application.loadedLevel == 8 && Input.GetKey(KeyCode.S))//Caso eu esteja na scene Menu, e aperte S de START
			Application.LoadLevel(Scenes[9]);//Carrega a StartCutscene
		if (Application.loadedLevel == 9 && Input.GetKey(KeyCode.S))//Caso eu esteja na scene Menu, e aperte S de START
			Application.LoadLevel(Scenes[10]);//Carrega a StartCutscene






		/*if (Application.loadedLevel == 1)//Aqui colocamos alguma condiçao que indique que a cutscene acabou, como uma booleana))
			Application.LoadLevel(Scenes[2]);//Carregar Fase 1
		if (Application.loadedLevel == 2)//Aqui colocamos uma bool indicando que o objetivo da fase 1 foi concluido, como pegar um item, ou matar um boss, etc))
			Application.LoadLevel(Scenes[3]);//Carregar Fase 2
		if (Application.loadedLevel == 3) //Aqui colocamos uma bool indicando que o objetivo da fase 2 foi concluido, como pegar um item, ou matar um boss, etc))
			Application.LoadLevel(Scenes[4]);//Carregar Fase 3
		if (Application.loadedLevel == 4 ) //Aqui colocamos uma bool indicando que o objetivo da fase 3 foi concluido, como pegar um item, ou matar um boss, etc))))//Caso eu esteja na scene Menu, e aperte S de START
			Application.LoadLevel(Scenes[5]);//Carregar Fase 4
		if (Application.loadedLevel == 5 ) //Aqui colocamos uma bool indicando que o objetivo da fase 4 foi concluido, como pegar um item, ou matar um boss, etc))))//Caso eu esteja na scene Menu, e aperte S de START
			Application.LoadLevel(Scenes[6]);//Carregar Fase 5
		if (Application.loadedLevel == 6 ) //Aqui colocamos uma bool indicando que o objetivo da fase 5 foi concluido, como pegar um item, ou matar um boss, etc))))//Caso eu esteja na scene Menu, e aperte S de START
			Application.LoadLevel(Scenes[7]);//Carregar Fase 6
		if (Application.loadedLevel == 7 ) //Aqui colocamos uma bool indicando que o objetivo da fase 6 foi concluido, como pegar um item, ou matar um boss, etc))))//Caso eu esteja na scene Menu, e aperte S de START
			Application.LoadLevel(Scenes[8]);//Carregar Fase 7
		if (Application.loadedLevel == 8 ) //Aqui colocamos uma bool indicando que o objetivo da fase 7 foi concluido, como pegar um item, ou matar um boss, etc))))//Caso eu esteja na scene Menu, e aperte S de START
			Application.LoadLevel(Scenes[9]);//Carregar Fase 8
		if (Application.loadedLevel == 9 ) //Aqui colocamos uma bool indicando que o objetivo da fase 8 foi concluido, como pegar um item, ou matar um boss, etc))))//Caso eu esteja na scene Menu, e aperte S de START
			Application.LoadLevel(Scenes[10]);//Carregar Fase 9
		if (Application.loadedLevel == 10 ) //Aqui colocamos uma bool indicando que o objetivo da fase 9 foi concluido, como pegar um item, ou matar um boss, etc))))//Caso eu esteja na scene Menu, e aperte S de START
			Application.LoadLevel(Scenes[11]);//Carregar Fase 10
		if (Application.loadedLevel == 11 ) //Aqui colocamos uma bool indicando que o objetivo da fase 10 foi concluido, como pegar um item, ou matar um boss, etc))))//Caso eu esteja na scene Menu, e aperte S de START
			Application.LoadLevel(Scenes[12 ]);//Carregar Fase 11
		if (Application.loadedLevel == 12 ) //Aqui colocamos uma bool indicando que o objetivo da fase 11 foi concluido, como pegar um item, ou matar um boss, etc))))//Caso eu esteja na scene Menu, e aperte S de START
			Application.LoadLevel(Scenes[13]);//Carregar Fase 12
		if (Application.loadedLevel == 13 ) //Aqui colocamos uma bool indicando que o objetivo da fase 12 foi concluido, como pegar um item, ou matar um boss, etc))))//Caso eu esteja na scene Menu, e aperte S de START
			Application.LoadLevel(Scenes[14]);//Carregar Fase 13
		if (Application.loadedLevel == 14 ) //Aqui colocamos uma bool indicando que o objetivo da fase 13 foi concluido, como pegar um item, ou matar um boss, etc))))//Caso eu esteja na scene Menu, e aperte S de START
			Application.LoadLevel(Scenes[15]);//Carregar EndCutscenel*/
	}
}
