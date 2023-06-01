using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int scoreTotal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increaseScore(int amount){
        scoreTotal += amount;
    }

    public int getScore(){
        return scoreTotal;
    }
}
