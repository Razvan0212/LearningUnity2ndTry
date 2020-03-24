using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{   
    public Transform player;
    public Text scoreText;
    public Text restartText;
    void Update()
    { 
        if (!FindObjectOfType<GameManager>().GetState())
            scoreText.text = player.position.z.ToString("0");

        if (FindObjectOfType<GameManager>().GetState())
        {
            restartText.text = "Please press enter in order to restart the game!";
            if (Input.GetKey(KeyCode.Return))
            {
                FindObjectOfType<GameManager>().Restart();
                restartText.text = "";
            }
        }

    }
}

