using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
	

public class screenController : MonoBehaviour {

    public AudioSource hornSound;

	public void changeLevel(string s)
    {
        SceneManager.LoadScene(s);
    }

    public void hitHorn()
    {
        hornSound.Play();
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
