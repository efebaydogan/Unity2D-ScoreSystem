using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Star")
        {
            Destroy(collision.gameObject);
            score += 1;
            scoreText.text = score.ToString();
        }
    }
}