using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    private GameController controller;

    void Start()
    {
        controller = FindObjectOfType<GameController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        controller.Score++;
        controller.scoreText.text = controller.Score.ToString();
    }
}
