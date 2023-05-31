using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] AudioClip musicTrack;
    [SerializeField] public float firstBeatOffset;
    public float songBpm;
    public float songPositionInBeats;
    float secPerBeat;
    float songPosition;
    float dspSongTime;
    // Start is called before the first frame update
    void Start()
    {
        // audioSource = GetComponent<AudioSource>();
        secPerBeat = 60f / songBpm;
        dspSongTime = (float)AudioSettings.dspTime;
        PlayMusicTrack();
    }

    // Update is called once per frame
    void Update()
    {
        songPosition = (float)(AudioSettings.dspTime - dspSongTime - firstBeatOffset);
        songPositionInBeats = songPosition / secPerBeat;
        Debug.Log(songPositionInBeats);

    }
    void PlayMusicTrack()
    {
        audioSource.PlayOneShot(musicTrack);
    }
}
