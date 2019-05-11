using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
 {

	 public Text messagetext, messageint;
	 public string messagestring;
	 public int desird;
	// Use this for initialization
	void Start () {
		messagetext.text  = "You Guessed it !\nLooks Like You are a Wizard!!!";
		GuessButton gb = new GuessButton();
		desird = GuessButton.desirednnum;
		messagestring = System.Convert.ToString(desird);
		messageint.text = messagestring;
		Debug.Log(messagestring);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
