using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PGSoundManager
{
    public static void PlaySound(string clipName, bool loop = false)
    {
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        if (loop)
        {
            audioSource.loop = true;
            audioSource.PlayOneShot(Resources.Load<AudioClip>(clipName));
        }
        else 
        {
            audioSource.PlayOneShot(Resources.Load<AudioClip>(clipName));
        }

    }
}
