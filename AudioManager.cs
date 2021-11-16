using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Music[] music;
    public static AudioManager instance;
    
    // Start is called before the first frame update
    void Awake()
    {
        if(instance == null) {
            instance = this;
        } else {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        foreach(Music s in music)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.loop = s.loop;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }
    private void Start()
    {
        Play("GameSong");
    }
    // Update is called once per frame
    public void Play (string name)
    {
        Music s = Array.Find(music, sound => sound.name == name);
        s.source.Play();
    }
}
