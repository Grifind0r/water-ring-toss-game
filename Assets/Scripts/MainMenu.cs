using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public new AudioSource audio;

    public void playButton()
    {
        audio.Play();
    }
}
