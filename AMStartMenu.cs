using UnityEngine.Audio;
using System;
using UnityEngine;

public class AMStartMenu : MonoBehaviour
{
    public Music[] music;
    private float timePassed;
    public static AMStartMenu instance;
    private bool playedBridge;
    private bool playedBasic;

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
        timePassed = 0;
        Play("Intro");
        playedBridge = false;
        playedBasic = false;
    }
    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if(timePassed > 19 && !playedBridge) {
            Play("Bridge");
            playedBridge = true;
        }
        if(timePassed > 38 && !playedBasic) {
            Play("Basic");
            playedBasic = true;
        }
    }
    public void Play (string name)
    {
        Music s = Array.Find(music, sound => sound.name == name);
        s.source.Play();
    }
}
