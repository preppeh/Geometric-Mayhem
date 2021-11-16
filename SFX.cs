using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
	// init variables
	public AudioSource pew;
	public AudioSource boom;

    public void PlayPew()
    {
        pew.Play(); 
    }
    public void PlayBoom()
    {
        boom.Play(); 
    }
}
