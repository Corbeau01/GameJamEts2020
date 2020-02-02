using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableADTutorial : MonoBehaviour
{
    public GameObject LeftImage;
    public GameObject RightImage;

    public Sprite NewImage1;
    public Sprite NewImage2;
    [SerializeField]
    private bool stillRelevant;

    // Start is called before the first frame update
    void Start()
    {
        stillRelevant=true;
    }
    bool ISFinished = false;
    // Update is called once per frame
    [SerializeField]
    int Icount = 0;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Icount++;
        }
        
        if (Icount>=2)
        {
            ISFinished = true;
            if(ISFinished)
            {
          
                LeftImage.SetActive(false);
                
            }

           
        }
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="Player")
        {
            if (stillRelevant)
            {
                RightImage.SetActive(false);

                LeftImage.GetComponent<AnimateKey>().image1 = NewImage1;
                LeftImage.GetComponent<AnimateKey>().image2 = NewImage2;

                stillRelevant = false;
            }
        }

        
        
    }
}
