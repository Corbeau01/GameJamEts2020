using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource Land;
    public AudioSource Jump;
    public AudioSource Repair;
    public AudioSource Sparkles;
    public AudioSource ViewShift;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayViewShift()
    {
        ViewShift.Play();
    }

    public void PlayRepair()
    {
        Repair.Play();
    }
    public void PlaySparkles()
    {
        Sparkles.Play();
    }
    public void PlayJump()
    {
        Jump.Play();
    }
    public void PlayLand()
    {
        Land.Play();
    }
}
