using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxManager : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            source.PlayOneShot(clip);
        }
    }
}
