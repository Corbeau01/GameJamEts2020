using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject FinalProductPrefab;
    public int myId = 0;
    public int myparts=0;
    [SerializeField]
    public bluePrints bp;
    int maxPart=0;
    bool ISConstructefd = false;

    public MusicManager musicManager;
    
    void Start()
    {
       if(myId==0)
        {
            this.maxPart = 4;
        }
        if (myId == 1)
        {
            this.maxPart = 6;
        }
        if (myId == 2)
        {
            this.maxPart = 3;
        }
        if (myId == 3)//piramidon
        {
            this.maxPart = 2;
        }
        if (myId == 4)
        {
            this.maxPart = 3;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(myparts==maxPart)
        {
            HasAllPArts();
        }
    }
    void HasAllPArts()
    {
        if(ISConstructefd==false)
        {
            if(myId==3)//piramidon
            {
                Camera.main.GetComponent<Wireframe>().Fixed = true;
                GameObject.Destroy(GameObject.Find("backGround1"));
            }
            if (myId == 4)//tesseract
            {
                FindObjectOfType<PlayerController>().RotateAxisUnlocked = true;
                musicManager.SwitchTo25D = true;
            }
            Instantiate(FinalProductPrefab, new Vector3(this.transform.position.x,this.transform.position.y,13f), Quaternion.identity);
            ISConstructefd = true;
            for (int i = 1; i < this.transform.childCount; i++)//ANAKIN
            {
                Destroy(this.transform.GetChild(i).gameObject);
                print("LightSaberNoise");
            }
        }
       
    }
}
