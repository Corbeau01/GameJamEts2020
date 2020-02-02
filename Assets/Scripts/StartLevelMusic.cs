using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevelMusic : MonoBehaviour
{
    public MusicManager musicManager;
    // Start is called before the first frame update
    void Start()
    {
        musicManager.StartLevelMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
