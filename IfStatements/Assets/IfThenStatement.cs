using UnityEngine;

public class IfThenStatement : MonoBehaviour
{
    public int myAge = 26;
    public bool canDrink = true;

    private void Start()
    {
        if (myAge > 18)
        {
            Debug.Log("I am older than 18");
        }
        else if (myAge < 5)
        {
            Debug.Log("Less than 5");
        }
        else
        {
            Debug.Log("Invalid");
        }

        if (canDrink == true)
        {
            Debug.Log("You can drink!");
        }
        else
        {
            Debug.Log("You can't!");
        }
    }
