using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour 
{
	//MELHORIAS
	//Organizar a disposiçao das linhas de codigo do update
	//Corrigir o numero das lists, de forma que fique mais facil entender qual scene eu estou trabalhando

	public List<bool> FinishedLevels;//Lista de booleanas, que mudam conforme o player completa as fases (Compleitei a fase 1 = Booleana 1 se torna verdadeira)
	public List<string> Scenes;//Lista que armazena as strings das scenes

	public Canvas CanvasChangeScene;//Canvas que possui os botoes de troca de tela
	public Canvas LevelSelectionCanvas;
	/*public Button BackLoadScene;//Botao para ir ate a scene de seleçao de fase
	public Button PlayAgain;//Botao para dar replay na fase
	public Button NextLevel;//Botao para ir ate a proxima fase*/


	void Start () 
	{
		CanvasChangeScene = (Canvas) FindObjectOfType (typeof(Canvas));
		CanvasChangeScene.enabled = false;

		LevelSelectionCanvas = (Canvas)FindObjectOfType (typeof(Canvas));

		if (LevelSelectionCanvas.name == "LevelSelection")
		{
			LevelSelectionCanvas.enabled = true;
		}
	}

	void Update () 
	{
//Carregando niveis, testando se terminei o anterior, testando se eu quero fazer a fase novamente, ir pra tela de escolha de fase ou ir para proxima fase
//-------------------------------------------------------------------------------------------
		if (Application.loadedLevel == 0 && Input.GetKey (KeyCode.S))//caso o player esteja no menu e aperte S
			Application.LoadLevel(Scenes[1]);//Carregar StartCutscene
//-------------------------------------------------------------------------------------
		if (Application.loadedLevel == 1 && Input.GetKey(KeyCode.S))//caso o player esteja na StartCutscene e aperte S 
			Application.LoadLevel(Scenes[2]);//Carregar Fase 1
//-------------------------------------------------------------------------------------
		if (Application.loadedLevel == 2 && FinishedLevels[0] == true)//Caso o player esteja na fase 1, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase2
		{
			CanvasChangeScene.enabled = true;
		}
//--------------------------------------------------------------------------------------
		if (Application.loadedLevel == 3 && FinishedLevels[1] == true)//Caso o player esteja na fase 2, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase3 
		{
			CanvasChangeScene.enabled = true;
		}
//---------------------------------------------------------------------------------------
		if (Application.loadedLevel == 4 && FinishedLevels[2] == true)//Caso o player esteja na fase 3, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase4 
		{
			CanvasChangeScene.enabled = true;
		}
//------------------------------------------------------------------------------------------
		if (Application.loadedLevel == 5 && FinishedLevels[3] == true)//Caso o player esteja na fase 4, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase5 
		{
			CanvasChangeScene.enabled = true;
		}
//-------------------------------------------------------------------------------------------
		if (Application.loadedLevel == 6 && FinishedLevels[4] == true)//Caso o player esteja na fase 5, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase6
		{
			CanvasChangeScene.enabled = true;
		}
//-------------------------------------------------------------------------------------------
		if (Application.loadedLevel == 7 && FinishedLevels[5] == true)//Caso o player esteja na fase 6, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase7 
		{
			CanvasChangeScene.enabled = true;
		}
//-------------------------------------------------------------------------------------------
		if (Application.loadedLevel == 8 && FinishedLevels[6] == true)//Caso o player esteja na fase 7, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase8 
		{
			CanvasChangeScene.enabled = true;
		}
//-------------------------------------------------------------------------------------------
		if (Application.loadedLevel == 9 && FinishedLevels[7] == true)//Caso o player esteja na fase 8, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase9
		{
			CanvasChangeScene.enabled = true;
		}
//-------------------------------------------------------------------------------------------
		if (Application.loadedLevel == 10 && FinishedLevels[8] == true)//Caso o player esteja na fase 9, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase10 
		{
			CanvasChangeScene.enabled = true;
		}
//-------------------------------------------------------------------------------------------
		if (Application.loadedLevel == 11 && FinishedLevels[9] == true)//Caso o player esteja na fase 10, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase11 
		{
			CanvasChangeScene.enabled = true;
		}
//-------------------------------------------------------------------------------------------
		if (Application.loadedLevel == 12 && FinishedLevels[10] == true)//Caso o player esteja na fase 11, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase12 
		{
			CanvasChangeScene.enabled = true;
		}
//-------------------------------------------------------------------------------------------
		if (Application.loadedLevel == 13 && FinishedLevels[11] == true)//Caso o player esteja na fase 12, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase13
		{
			CanvasChangeScene.enabled = true;
		}
//-------------------------------------------------------------------------------------------
		if (Application.loadedLevel == 14 && FinishedLevels[12] == true)//Caso o player esteja na fase 13, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase14
		{
			CanvasChangeScene.enabled = true;
		}
//-------------------------------------------------------------------------------------------
	}

	public void LevelSelection()
	{
		Application.LoadLevel(Scenes [19]);
	}

	public void PlayAgain()
	{
		Application.LoadLevel(Application.loadedLevel);
	}

	public void NextLevel()
	{
		Application.LoadLevel(Application.loadedLevel + 1);
		if(Application.loadedLevel >= 19)
		{
			Application.LoadLevel(Scenes[0]);
		}
	}

	public void LevelSelectionMenu(int LevelToLoad)
	{
		switch(LevelToLoad)
		{
			case(0):
			Application.LoadLevel(Scenes[2]);
			break;
			case(1):
			Application.LoadLevel(Scenes[3]);
			break;
			case(2):
			Application.LoadLevel(Scenes[4]);
			break;
			case(3):
			Application.LoadLevel(Scenes[5]);
			break;
			case(4):
			Application.LoadLevel(Scenes[6]);
			break;
			case(5):
			Application.LoadLevel(Scenes[7]);
			break;
			case(6):
			Application.LoadLevel(Scenes[8]);
			break;
			case(7):
			Application.LoadLevel(Scenes[9]);
			break;
			case(8):
			Application.LoadLevel(Scenes[10]);
			break;
			case(9):
			Application.LoadLevel(Scenes[11]);
			break;
			case(10):
			Application.LoadLevel(Scenes[12]);
			break;
			case(11):
			Application.LoadLevel(Scenes[13]);
			break;
			case(12):
			Application.LoadLevel(Scenes[14]);
			break;
		}
	}
}
