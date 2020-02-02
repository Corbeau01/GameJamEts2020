using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveJumpTutorial : MonoBehaviour
{

    public GameObject RightImage;

    public bool Relevant;
    // Start is called before the first frame update
    void Start()
    {
        Relevant = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (Relevant)
        {
            RightImage.GetComponent<AnimateKey>().image1 = null;
            RightImage.GetComponent<AnimateKey>().image2 = null;
            RightImage.SetActive(false);
            Relevant = false;
        }
    }

    public void RelevantNow()
    {
        Relevant = true;
    }
}
