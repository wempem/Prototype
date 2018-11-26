using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour {

    public string[] sceneNames;
	public void ChangeScene()
	{
		string sceneName = sceneNames[Random.Range(0, sceneNames.Length)];
		SceneManager.LoadScene(sceneName);
	}
}
