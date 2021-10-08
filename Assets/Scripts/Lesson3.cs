using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] arr = { -1, 53, 21, 16, 4 };
        for(int i = 0; i < 5; i++)
        {
            arr[i] = arr[i] * 2;
            Debug.Log(arr[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
