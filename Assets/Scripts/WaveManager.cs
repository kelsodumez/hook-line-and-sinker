using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public static WaveManager instance;
    [SerializeField] private float amplitude = 1f;
    [SerializeField] private float length = 2f;
    [SerializeField] private float speed = 1f;
    [SerializeField] private float offset = 0f;

    private void Awake() {
        if (instance == null){
            instance = this;
        }
        else if (instance != this){
            // Debug.Log("wave instance already exists, destroying object!");
            Destroy(this);
        }
    }

    private void Update() {
        offset += Time.deltaTime * speed;
    }

    public float GetWaveHeight(float _x){
        return amplitude * Mathf.Sin(_x / length + offset);
    }
}
