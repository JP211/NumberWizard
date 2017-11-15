using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
		int max;
		int min;
		int guess;
	

	// Use this for initialization
	void Start () {
	
		max = 1000;
		min = 1;
		guess = 500;
		
		StartGame();
		 
	}
	
	void StartGame () {
		
		print ("=======================================");
		
		print ("Welcome to Number Wizard");
		print ("Choose a secret number - don't tell me!");
		
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		max = max + 1;
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Choose the up arrow for higher, down for lower and return for equal.");
	}
	
	void NextGuess () {
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess);
		print ("Choose the up arrow for higher, down for lower and return for equal.");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
//			print("Up arrow pressed");
			min = guess;
			NextGuess();
			
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
//			print("Down arrow pressed");
			max = guess;
			NextGuess();
	
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print("Woo Hoo I Won!!");
			print ("Let's Play Again!!");
			StartGame();
		}
	
	}
	
}
