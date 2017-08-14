using UnityEngine;

public class ArrayExample2 : MonoBehaviour
{
    public string[] names = { "Jon", "Julie", "Mark", "Harison", "George" };
    public int[] ages = { 22, 26, 38, 40, 18 };

    void Start()
    {
        for (int i = 0; i < names.Length; i++)
        {
            Debug.Log("My name is " + names[i] + " and I'm " + ages[i]);
        }

        for (int j = 1; j <= 10; j++)
        {
            if (j == 6)
            {
                continue;
            }
            else if (j == 7)
            {
                Debug.Log(j);
                break;
            }
            Debug.Log(j);
        }
        Debug.Log("You broke the loop early!");
    }

    void Update()
    {

    }
}
