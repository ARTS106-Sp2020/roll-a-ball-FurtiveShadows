using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

	public void StartGame()
	{
		SceneManager.LoadScene("Roll-a-ball");
	}
	
	public void TitleScreen()
	{
		SceneManager.LoadScene("MainMenu");
	}
	
	public void ExitGame()
	{
		Application.Quit();
	}
	
}
