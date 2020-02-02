using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aSchematic : MonoBehaviour
{

    public int myParts = 0;
    public int maxParts = 0; 

    [SerializeField]
    public bluePrints.bluePrintsEnum thisBluePrint;

    void Start()
    {
        switch (thisBluePrint)
        {
            case bluePrints.bluePrintsEnum.Walkman :
                maxParts = 6;
                break;
            case bluePrints.bluePrintsEnum.Ladder:
                maxParts = 4;
                break;
            case bluePrints.bluePrintsEnum.Cart:
                maxParts = 3;
                break;
         }       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
