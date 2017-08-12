using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

    public int[] numbers = { 5, 6, 7, 8 };

    public int apples = 100;
	// Use this for initialization
	void Start ()
    {
		for(int i=0;i<numbers.Length;i++)
        {
            Debug.Log(numbers[i]);
        }

        foreach(var number in numbers)
        {
            Debug.Log(number);
        }

        do
        {
            Debug.Log("Apples" + apples);
            apples--;
        }
        while (apples >= 1);

        Debug.Log("The wile loop finished! Yay for no crash!,");
	}
	
	
}
