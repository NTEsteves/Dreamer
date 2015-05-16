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

	public Button BackLoadScene;//Botao para ir ate a scene de seleçao de fase
	public Button PlayAgain;//Botao para dar replay na fase
	public Button NextLevel;//Botao para ir ate a proxima fase


	void Start () 
	{
	}

	void Update () 
	{
//Carregando niveis, testando se terminei o anterior, testando se eu quero fazer a fase novamente, ir pra tela de escolha de fase ou ir para proxima fase
//-------------------------------------------------------------------------------------------
		if (Application.loadedLevel == 0 && Input.GetKey(KeyCode.S))//caso o player esteja no menu e aperte S
			Application.LoadLevel(Scenes[1]);//Carregar StartCutscene
//-------------------------------------------------------------------------------------
		if (Application.loadedLevel == 1 && Input.GetKey(KeyCode.S))//caso o player esteja na StartCutscene e aperte S 
			Application.LoadLevel(Scenes[2]);//Carregar Fase 1
//-------------------------------------------------------------------------------------
		if (Application.loadedLevel == 2 && FinishedLevels[0] == true)//Caso o player esteja na fase 1, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase2
		{
			//Linha reservada para colocar o aparecimento(Ativar o renderer) da UI com as opçoes de final de fase (Voltar a tela de carregamento, repetir a fase, ir para a proxima)
			
			if(BackLoadScene == true)//Testa se o player clicou no botao "Voltar a tela de carregamento"
			{
				Application.LoadLevel(Scenes[20]);
			}
			
			else if(PlayAgain)//Testa se o player clicou no botao "Repetir a fase"
			{
				Application.LoadLevel(Application.loadedLevel); 
			} 
			
			else if(NextLevel)//Testa se o player clicou no botao "Ir para proxima fase"
			{
				Application.LoadLevel (Scenes[3]);
			};
		}
//--------------------------------------------------------------------------------------
		if (Application.loadedLevel == 3 && FinishedLevels[1] == true)//Caso o player esteja na fase 2, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase3 
		{
			//Linha reservada para colocar o aparecimento(Ativar o renderer) da UI com as opçoes de final de fase (Voltar a tela de carregamento, repetir a fase, ir para a proxima)
			
			if(BackLoadScene == true)//Testa se o player clicou no botao "Voltar a tela de carregamento"
			{
				Application.LoadLevel(Scenes[20]);
			}
			
			else if(PlayAgain)//Testa se o player clicou no botao "Repetir a fase"
			{
				Application.LoadLevel(Application.loadedLevel); 
			} 
			
			else if(NextLevel)//Testa se o player clicou no botao "Ir para proxima fase"
			{
				Application.LoadLevel (Scenes[4]);
			};
		}
//---------------------------------------------------------------------------------------
		if (Application.loadedLevel == 4 && FinishedLevels[2] == true)//Caso o player esteja na fase 3, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase4 
		{
			//Linha reservada para colocar o aparecimento(Ativar o renderer) da UI com as opçoes de final de fase (Voltar a tela de carregamento, repetir a fase, ir para a proxima)
				
			if(BackLoadScene == true)//Testa se o player clicou no botao "Voltar a tela de carregamento"
			{
				Application.LoadLevel(Scenes[20]);
			}
			
			else if(PlayAgain)//Testa se o player clicou no botao "Repetir a fase"
			{
				Application.LoadLevel(Application.loadedLevel); 
			} 
			
			else if(NextLevel)//Testa se o player clicou no botao "Ir para proxima fase"
			{
				Application.LoadLevel (Scenes[5]);
			};
		}
//------------------------------------------------------------------------------------------
		if (Application.loadedLevel == 5 && FinishedLevels[3] == true)//Caso o player esteja na fase 4, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase5 
		{
			//Linha reservada para colocar o aparecimento(Ativar o renderer) da UI com as opçoes de final de fase (Voltar a tela de carregamento, repetir a fase, ir para a proxima)
				
			if(BackLoadScene == true)//Testa se o player clicou no botao "Voltar a tela de carregamento"
			{
				Application.LoadLevel(Scenes[20]);
			}
			
			else if(PlayAgain)//Testa se o player clicou no botao "Repetir a fase"
			{
				Application.LoadLevel(Application.loadedLevel); 
			} 
			
			else if(NextLevel)//Testa se o player clicou no botao "Ir para proxima fase"
			{
				Application.LoadLevel (Scenes[6]);
			};
		}
//-------------------------------------------------------------------------------------------
		if (Application.loadedLevel == 6 && FinishedLevels[4] == true)//Caso o player esteja na fase 5, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase6
		{
			//Linha reservada para colocar o aparecimento(Ativar o renderer) da UI com as opçoes de final de fase (Voltar a tela de carregamento, repetir a fase, ir para a proxima)
				
			if(BackLoadScene == true)//Testa se o player clicou no botao "Voltar a tela de carregamento"
			{
				Application.LoadLevel(Scenes[20]);
			}
			
			else if(PlayAgain)//Testa se o player clicou no botao "Repetir a fase"
			{
				Application.LoadLevel(Application.loadedLevel); 
			} 
			
			else if(NextLevel)//Testa se o player clicou no botao "Ir para proxima fase"
			{
				Application.LoadLevel (Scenes[7]);
			};
		}
//-------------------------------------------------------------------------------------------
		if (Application.loadedLevel == 7 && FinishedLevels[5] == true)//Caso o player esteja na fase 6, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase7 
		{
			//Linha reservada para colocar o aparecimento(Ativar o renderer) da UI com as opçoes de final de fase (Voltar a tela de carregamento, repetir a fase, ir para a proxima)
				
			if(BackLoadScene == true)//Testa se o player clicou no botao "Voltar a tela de carregamento"
			{
				Application.LoadLevel(Scenes[20]);
			}
			
			else if(PlayAgain)//Testa se o player clicou no botao "Repetir a fase"
			{
				Application.LoadLevel(Application.loadedLevel); 
			} 
			
			else if(NextLevel)//Testa se o player clicou no botao "Ir para proxima fase"
			{
				Application.LoadLevel (Scenes[8]);
			};
		}
//-------------------------------------------------------------------------------------------
		if (Application.loadedLevel == 8 && FinishedLevels[6] == true)//Caso o player esteja na fase 7, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase8 
		{
			//Linha reservada para colocar o aparecimento(Ativar o renderer) da UI com as opçoes de final de fase (Voltar a tela de carregamento, repetir a fase, ir para a proxima)
				
			if(BackLoadScene == true)//Testa se o player clicou no botao "Voltar a tela de carregamento"
			{
				Application.LoadLevel(Scenes[20]);
			}

			else if(PlayAgain)//Testa se o player clicou no botao "Repetir a fase"
			{
				Application.LoadLevel(Application.loadedLevel); 
			} 
			
			else if(NextLevel)//Testa se o player clicou no botao "Ir para proxima fase"
			{
				Application.LoadLevel (Scenes[9]);
			};
		}
//-------------------------------------------------------------------------------------------
		if (Application.loadedLevel == 9 && FinishedLevels[7] == true)//Caso o player esteja na fase 8, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase9
		{
			//Linha reservada para colocar o aparecimento(Ativar o renderer) da UI com as opçoes de final de fase (Voltar a tela de carregamento, repetir a fase, ir para a proxima)
				
			if(BackLoadScene == true)//Testa se o player clicou no botao "Voltar a tela de carregamento"
			{
				Application.LoadLevel(Scenes[20]);
			}
			
			else if(PlayAgain)//Testa se o player clicou no botao "Repetir a fase"
			{
				Application.LoadLevel(Application.loadedLevel); 
			} 
			
			else if(NextLevel)//Testa se o player clicou no botao "Ir para proxima fase"
			{
				Application.LoadLevel (Scenes[10]);
			};
		}
//-------------------------------------------------------------------------------------------
		if (Application.loadedLevel == 10 && FinishedLevels[8] == true)//Caso o player esteja na fase 9, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase10 
		{
			//Linha reservada para colocar o aparecimento(Ativar o renderer) da UI com as opçoes de final de fase (Voltar a tela de carregamento, repetir a fase, ir para a proxima)
				
			if(BackLoadScene == true)//Testa se o player clicou no botao "Voltar a tela de carregamento"
			{
				Application.LoadLevel(Scenes[20]);
			}
			
			else if(PlayAgain)//Testa se o player clicou no botao "Repetir a fase"
			{
				Application.LoadLevel(Application.loadedLevel); 
			} 
			
			else if(NextLevel)//Testa se o player clicou no botao "Ir para proxima fase"
			{
				Application.LoadLevel (Scenes[11]);
			};
		}
//-------------------------------------------------------------------------------------------
		if (Application.loadedLevel == 11 && FinishedLevels[9] == true)//Caso o player esteja na fase 10, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase11 
		{
			//Linha reservada para colocar o aparecimento(Ativar o renderer) da UI com as opçoes de final de fase (Voltar a tela de carregamento, repetir a fase, ir para a proxima)
				
			if(BackLoadScene == true)//Testa se o player clicou no botao "Voltar a tela de carregamento"
			{
				Application.LoadLevel(Scenes[20]);
			}
			
			else if(PlayAgain)//Testa se o player clicou no botao "Repetir a fase"
			{
				Application.LoadLevel(Application.loadedLevel); 
			} 
			
			else if(NextLevel)//Testa se o player clicou no botao "Ir para proxima fase"
			{
				Application.LoadLevel (Scenes[12]);
			};
		}
//-------------------------------------------------------------------------------------------
		if (Application.loadedLevel == 12 && FinishedLevels[10] == true)//Caso o player esteja na fase 11, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase12 
		{
			//Linha reservada para colocar o aparecimento(Ativar o renderer) da UI com as opçoes de final de fase (Voltar a tela de carregamento, repetir a fase, ir para a proxima)
				
			if(BackLoadScene == true)//Testa se o player clicou no botao "Voltar a tela de carregamento"
			{
				Application.LoadLevel(Scenes[20]);
			}
			
			else if(PlayAgain)//Testa se o player clicou no botao "Repetir a fase"
			{
				Application.LoadLevel(Application.loadedLevel); 
			} 
			
			else if(NextLevel)//Testa se o player clicou no botao "Ir para proxima fase"
			{
				Application.LoadLevel (Scenes[13]);
			};
		}
//-------------------------------------------------------------------------------------------
		if (Application.loadedLevel == 13 && FinishedLevels[11] == true)//Caso o player esteja na fase 12, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase13
		{
			//Linha reservada para colocar o aparecimento(Ativar o renderer) da UI com as opçoes de final de fase (Voltar a tela de carregamento, repetir a fase, ir para a proxima)
				
			if(BackLoadScene == true)//Testa se o player clicou no botao "Voltar a tela de carregamento"
			{
				Application.LoadLevel(Scenes[20]);
			}
			
			else if(PlayAgain)//Testa se o player clicou no botao "Repetir a fase"
			{
				Application.LoadLevel(Application.loadedLevel); 
			} 
			
			else if(NextLevel)//Testa se o player clicou no botao "Ir para proxima fase"
			{
				Application.LoadLevel (Scenes[14]);
			};
		}
//-------------------------------------------------------------------------------------------
		if (Application.loadedLevel == 14 && FinishedLevels[12] == true)//Caso o player esteja na fase 13, e a booleana que indica que ele concluiu a fase for verdadeira, ele vai para a fase14
		{
			//Linha reservada para colocar o aparecimento(Ativar o renderer) da UI com as opçoes de final de fase (Voltar a tela de carregamento, repetir a fase, ir para a proxima)
				
			if(BackLoadScene == true)//Testa se o player clicou no botao "Voltar a tela de carregamento"
			{
				Application.LoadLevel(Scenes[20]);
			}
			
			else if(PlayAgain)//Testa se o player clicou no botao "Repetir a fase"
			{
				Application.LoadLevel(Application.loadedLevel); 
			} 
			
			else if(NextLevel)//Testa se o player clicou no botao "Ir para proxima fase"
			{
				Application.LoadLevel (Scenes[15]);
			};
		}
//-------------------------------------------------------------------------------------------
	}
}
