using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    // public int[] quizes = new int[3];

    /*//Elements
    public int quiz1 = 50;
    public int quiz2 = 100;
    public int quiz3 = 70;*/

    public int[] quizes = { 50, 100, 70 };

    public string[] names ={"Person1","Person2", "Person3" };

    public GameObject[] myObjects;
  
    // Use this for initialization
    void Start ()
    {
        Debug.Log(quizes[2]);
        Debug.Log(names[0]);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
