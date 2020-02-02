using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimateKey : MonoBehaviour
{
    public Sprite image1;
    public Sprite image2;
    public float TimeToSwitch;
    private float time;
    private bool isImage1;
    
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        isImage1 = true;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > TimeToSwitch)
        {
            if (isImage1)
            {
                GetComponent<Image>().sprite = image1;
                isImage1 = false;
            }
            else
            {
                GetComponent<Image>().sprite = image2;
                isImage1 = true;
            }
            time = 0;
        }
    }
}
