using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class features : MonoBehaviour
{
    public enum unlockableFeatures
    {
        wireframe,
        couleur,
        sound,
        twoPointFivey,
        twoPointFivex,
        twoPointFivez,
        Threed
    }



    public List<unlockableFeatures> unlockedFeatures;

    public void Awake()
    {
        unlockedFeatures = new List<unlockableFeatures>();
    }

    public void unlockFeature(unlockableFeatures featToUnlock)
    {
        if (!unlockedFeatures.Contains(featToUnlock))
        {
            unlockedFeatures.Add(featToUnlock);
           // Debug.Log("feature unlocked");
        }
    }

    public bool checkIfFeatureUnlocked(unlockableFeatures feature)
    {
        return unlockedFeatures.Contains(feature); 
    }

}
