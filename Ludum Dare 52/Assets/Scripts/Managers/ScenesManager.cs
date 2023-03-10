using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public static ScenesManager Instance;

	private void Awake()
	{
		Instance = this;
	}

	public enum Scene
	{
		MainMenu,
		Level01,
		Level02,
		Level03,
		Level04,
		Level05,
		Level06,
		Level07,
		Level08,
		Credits
	}

	public void LoadScene(Scene scene)
	{
		SceneManager.LoadScene(scene.ToString());
	}

	public void LoadNewGame()
	{
		SceneManager.LoadScene(Scene.Level01.ToString());
	}

	public void LoadNextScene()
	{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void ReloadScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void LoadMainMenu()
	{
		SceneManager.LoadScene(Scene.MainMenu.ToString());
	}
}
