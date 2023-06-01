using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    public GameObject gameManager;
    public TextMeshPro scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int currentScore = gameManager.GetComponent<GameManager>().getScore();
        scoreText.SetText("Score: " + currentScore);
    }
}
