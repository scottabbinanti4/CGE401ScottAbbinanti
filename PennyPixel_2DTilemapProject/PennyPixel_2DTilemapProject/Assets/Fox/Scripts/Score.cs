using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public GameObject winText;
    public GameObject loseText;

    public Text textbox;
    public int score;

    private bool won;

    // Start is called before the first frame update
    void Start()
    {
        won = false;
        score = 0;
        textbox.text = "Score: " + score;
    }

    void Update()
    {
        textbox.text = "Score: " + score;

        if (transform.position.y < -5)
        {
            loseText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if (won)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("WinTrigger"))
        {
            winText.SetActive(true);
            won = true;
        }
        else if (other.gameObject.CompareTag("Gem"))
        {
            score++;
        }
    }
}
