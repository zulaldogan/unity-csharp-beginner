using UnityEngine;

public class QuizGradeCalculator : MonoBehaviour
{
    public float quiz1, quiz2, quiz3, quiz4, quiz5;
    public float average;

    void Start()
    {
        quiz1 = Random.Range(0f, 100.1f);//Random Float Numbers(0-100)
        quiz2 = Random.Range(0f, 100.1f);
        quiz3 = Random.Range(0f, 100.1f);
        quiz4 = Random.Range(0f, 100.1f);
        quiz5 = Random.Range(0f, 100.1f);

        average = (quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5;
        average = Mathf.Round(average * 100) / 100;

        //if average is greater than 90
        //print you have an A
        if (average >= 90)
        {
            Debug.Log("You have an A!");
        }
        else if (average >= 80 && average < 90)
        {
            Debug.Log("You have a B");
        }
        else if (average >= 70 && average < 80)
        {
            Debug.Log("You have a C");
        }
        else
        {
            Debug.Log("You have a F");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //recalculate average with new quiz grades
            Start();
        }
    }
}
