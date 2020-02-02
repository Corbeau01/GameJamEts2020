using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bluePrints : MonoBehaviour
{

    public enum bluePrintsEnum
    {
        Walkman,
        Ladder,
        Cart
    }

    public  List<bluePrintsEnum> ownedBluePrints;

    public void Awake()
    {
        ownedBluePrints = new List<bluePrintsEnum>();
    }

    public void addBluePrint(bluePrintsEnum bluePrintToAdd)
    {

        if (!ownedBluePrints.Contains(bluePrintToAdd))
        {
            ownedBluePrints.Add(bluePrintToAdd);
        }
    }
    public bool checkIfBluePrintOwned(bluePrintsEnum bluePrint)
    {
        return ownedBluePrints.Contains(bluePrint);
    }

}
