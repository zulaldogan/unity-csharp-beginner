using UnityEngine;

public class ArrayExample3 : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var cubeArray = GameObject.FindGameObjectsWithTag("Cube");

            for (int i = 0; i < cubeArray.Length; i++)
            {
                var renderer = cubeArray[i].GetComponent<Renderer>();
                renderer.material.color = Color.red;
            }
        }
    }
}
