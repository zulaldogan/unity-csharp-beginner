using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Statements : MonoBehaviour
{
    public int a ;
    public int b ;
    public int c ;
    public int average;

    // Use this for initialization
    void Start ()
    {
        average = (a + b + c) / 3;

       /* if(average==16)
        {
            Debug.Log("Average is 16");
        }
        else if(average==5)
        {
            Debug.Log("Average is 5");
        }
        else if (average ==10)
        {
            Debug.Log("Average is 10");
        }
        else
        {
            Debug.Log("Invalid");
        } */

        switch (average)
        {
            case 16:
                Debug.Log("Average is 16");
                break;
            case 10:
                Debug.Log("Average is 10");
                break;
            default:
                Debug.Log("This is default case!");
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
