using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//public class Class3 : MonoBehaviour
//{

//    void Start()
//    {
//        MyMethod();

//    }

//    void MyMethod()
//    {

//        Debug.Log("This is my method!");
//    }


//}
public class ClassWork3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int varOne = 3;
        int varTwo = 5;

        varOne = varOne * 2;
        varTwo = varTwo / 5;

        Debug.Log(varOne == varTwo);

        if (varOne == varTwo)
        {
            Debug.Log("They are equals");

        }

        Debug.Log("They are not equals");

    }

    void MyMethod()
    {


    }


}