using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ButtonController : MonoBehaviour
 {


	public void Play()
	{
		SceneManager.LoadScene(1);
		
	}
	public void quit()
	{
		Application.Quit();
	}

	void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

	public void mainMenu()
	{
		SceneManager.LoadScene(0);
	}


}
