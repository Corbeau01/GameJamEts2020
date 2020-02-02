using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource MainTheme;
    public AudioSource MainThemeFlute;

    public AudioSource MainTheme3;
    public AudioSource MainTheme3Flute;
    public AudioSource MainTheme2;
    public AudioSource MainMenu;
    public AudioSource MainMenuLoop;

    public AudioSource MainMenuGlitchLoop;
    public AudioSource MainMenuGlitch;

    public bool SwitchTo25D;
    public float FadeSpeed;
    public float FadeFluteSpeed;
    public bool IsMoving;

    // Start is called before the first frame update
    void Start()
    {
        IsMoving = false;
        SwitchTo25D = false;
    }
    void Update()
    {
        // changer de 2d a 2.5d
        if (SwitchTo25D)
        {
            if (MainTheme3.volume >= 1)
            {
                MainTheme3.volume = 1;
            }
            else
            {
                MainTheme.volume -= Time.deltaTime * FadeSpeed;
                MainTheme3.volume += Time.deltaTime * FadeSpeed;
            }
        }

        // ajouter la flute pendant le mouvement
        if (IsMoving)
        {
            print("OUI");
            if (SwitchTo25D)
            {
                MainTheme3Flute.volume += Time.deltaTime * FadeFluteSpeed;
            }
            else
            {
                MainThemeFlute.volume += Time.deltaTime * FadeFluteSpeed;
            }
        }
        else
        {
            if (SwitchTo25D)
            {
                MainTheme3Flute.volume -= Time.deltaTime * FadeFluteSpeed;
            }
            else
            {
                MainThemeFlute.volume -= Time.deltaTime * FadeFluteSpeed;
            }
        }


        if (MainMenu.time == 90)
        {
            MainMenu.Stop();
            MainMenuLoop.Play();
        }

        if (MainMenuGlitch.time == 91)
        {
            MainMenuGlitch.Stop();
            MainMenuGlitchLoop.Play();
        }


    }

    public void Start25DLevelMusic()
    {
        
    }

    public void StartLevelMusic()
    {
        MainTheme3Flute.volume = 0.0f;
        MainTheme3.volume = 0.0f;
        MainTheme.volume = 1.0f;
        MainThemeFlute.volume = 0.0f;
        MainTheme3.Play();
        MainTheme3Flute.Play();
        MainTheme.Play();
        MainThemeFlute.Play();
    }

    public void StartIntroMusic()
    {
        MainTheme2.Play();
    }

    public void StartMainMenuMusic()
    {
        MainMenu.Play();
    }

    public void StartMainMenuGlitchMusic()
    {
        MainMenuGlitch.Play();
    }

    public void StartCreditsMusic()
    {
        MainMenuGlitch.Play();
    }
}
