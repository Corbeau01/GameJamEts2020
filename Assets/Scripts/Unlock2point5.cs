using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock2point5 : MonoBehaviour
{

    private features Feats;
    public features.unlockableFeatures FeatureToUnlock;

    // Start is called before the first frame update
    void Start()
    {
        Feats = FindObjectOfType<features>();
        Feats.unlockFeature(FeatureToUnlock);   
    }

    // Update is called once per frame
    void Update()
    {

    }
}
