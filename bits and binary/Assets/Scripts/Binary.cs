using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Binary : MonoBehaviour
{
    // the addition here is placed to show how decimal numbers can be easily built from binary
    int decimalNum = 256 + 64 + 16 + 2 + 1;

    // Start is called before the first frame update
    void Start()
    {
        // this will output the binary represenation of decimalNum
        Debug.Log(Convert.ToString(decimalNum, 2));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
