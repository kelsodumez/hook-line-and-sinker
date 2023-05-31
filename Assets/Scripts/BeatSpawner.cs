using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatSpawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] spawnPoints;
    public SoundManager soundManager;
    float nextBeatToSpawnNote = 0.0f;
    public List<Beat> beatStream;
    // Update is called once per frame
    void Update()
    {
        if (soundManager.songPositionInBeats >= nextBeatToSpawnNote){
            SpawnBeat();
            nextBeatToSpawnNote += 4.0f;

        }
    }

    void SpawnBeat(){
        Instantiate(cubes[Random.Range(0, cubes.Length)], spawnPoints[Random.Range(0, spawnPoints.Length)]);
    }

    public bool IsInTime(){
        if((soundManager.songPositionInBeats % 1) < 0.4){
            Debug.Log(soundManager.songPositionInBeats +"HIT");
            return true;
        } else{
            return false;
        }
    }
}
