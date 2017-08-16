using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    public int[] quizes = { 50, 100, 70 };
    public string[] names = { "Person1", "Person2", "Person3" };
    public GameObject[] myObjects;

    void Start()
    {
        Debug.Log(quizes[2]);
        Debug.Log(names[0]);
    }

    void Update()
    {

    }
}
