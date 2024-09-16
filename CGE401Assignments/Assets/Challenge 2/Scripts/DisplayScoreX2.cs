/*
 * Scott Abbinanti
 * DisplayScoreX2
 * CGE 401 Challenge 2
 * Script to display score
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScoreX2 : MonoBehaviour
{
    public Text textbox;

    public int score = 0;

    public GameObject winText;


    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();
        textbox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;

        if (score >= 5)
        {
            GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>().gameOver = true;
            winText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.R))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
            }
        }
    }
}
