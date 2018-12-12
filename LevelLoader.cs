using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

	[SerializeField] int timeToWait = 4;
	int currentScenedIndex;

	// Use this for initialization
	void Start () {
		currentScenedIndex = SceneManager.GetActiveScene().buildIndex;
		if (currentScenedIndex == 0)
		{
			StartCoroutine(WaitForTime());
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator WaitForTime()
	{
		yield return new WaitForSeconds(timeToWait);
		LoadNextScene();
	}

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentScenedIndex + 1);
	}
}
