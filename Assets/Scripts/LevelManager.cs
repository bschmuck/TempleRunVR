using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			NextScene ();
		}
	}

	void NextScene() {
		int currentIndex = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (currentIndex + 1);
	}

	void PrevScene() {
		int currentIndex = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (currentIndex - 1);
	}
}
