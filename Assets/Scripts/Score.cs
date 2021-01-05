using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _scoreText;

    public static int score = 0;
    
    void Start()
    {
        score = 0;
    }

    void Update()
    {
        _scoreText.text = score.ToString();
    }
}
