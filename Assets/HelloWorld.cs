using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    void Start()
    {
        int a = Square(5);
        int b = Square(10);

        Debug.Log(a);
    }

    int Square(int x)
    {
        int a = x * x;
        return a;
    }








    // Update is called once per frame
    void Update()
    {

    }


}
