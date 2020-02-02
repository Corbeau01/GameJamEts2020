using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    int myListId;
    bluePrints bp;

    private void Start()
    {
        bp = FindObjectOfType<bluePrints>();
    }
    public void b1()
    {

        print("hello");


        print("test");

    }

    public void loadNextSchematic()
    {

    }

}

