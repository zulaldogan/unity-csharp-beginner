using UnityEngine;

public class DifficultyLevelSelector : MonoBehaviour
{
    public int curentDifficulty;
    public int easy = 0, normal = 1, hard = 2;
    // Use this for initialization
    void Start()
    {
        /*if(curentDifficulty==easy)
        {
            Debug.Log("You selected Easy");
        }
        else if(curentDifficulty==normal)
        {
            Debug.Log("You selected Normal");
        }
        else if(curentDifficulty==hard)
        {
            Debug.Log("You selected Hard");
        }*/

        switch (curentDifficulty)
        {
            case 0:
                Debug.Log("You selected Easy");
                break;
            case 1:
                Debug.Log("You selected Normal");
                break;
            case 2:
                Debug.Log("You selected Hard");
                break;
            default:
                Debug.Log("Invalid selection");
                break;
        }
    }

    void Update()
    {

    }
}
