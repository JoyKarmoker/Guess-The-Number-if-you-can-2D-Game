using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GuessButton : MonoBehaviour {
	public InputField iField;
	public string gussedstring;
	 int num;

	 public Text messagetext;
	  public int computersnumber;

	  public static int desirednnum;



	// Use this for initialization
	void Start () {
		messagetext.text = "Guess A Number Between One to Hundred";
		computersnumber = Random.Range(1,101);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void guess()
	{
		gussedstring = iField.text;	
		num = System.Convert.ToInt32(gussedstring);
		//Debug.Log(num);
		if(num > computersnumber)
		{
			messagetext.text = "Too High..........Guess Lower"; 
		}

		else if(num < computersnumber)
		{
			messagetext.text = "Too Low..........Guess higher";
		}

		else
		{
			desirednnum = num;
			//messagetext.text = "You Guessed it!\nLooks Like You are a Wizard!!!";
			SceneManager.LoadScene(2);
		}
	}

}
