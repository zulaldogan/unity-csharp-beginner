using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Degree : MonoBehaviour {
    public int selectedLevel;
    private int easy = 0, medium = 1, hard = 2;

	// Use this for initialization
	void Start () {
		switch(selectedLevel)
        {
            case 0:
                Debug.Log("You selected Easy");
                break;
            case 1:
                Debug.Log("You selected Medium");
                break;
            case 2:
                Debug.Log("You selected Hard");
                break;
            default:
                Debug.Log("You didn't select");
                break;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
