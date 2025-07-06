using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public UiManager uiManager;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        uiManager = FindObjectOfType<UiManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore()
    {
        score++;
        uiManager.UpdateScore(score);
    }
    public void  AddScore(int scorePoints)
    {
        score += scorePoints;
        uiManager.UpdateScore(score);
    }
}
