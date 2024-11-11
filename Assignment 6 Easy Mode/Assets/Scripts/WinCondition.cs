/*
 * Scott Abbinanti
 * WinCondition
 * Assignment5B
 * Activates Win when player collides with
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public GameObject winText;
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver == true)
        {
            winText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

        if(GameObject.FindWithTag("Dummy") == null)
        {
            gameOver = true;
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Finish"))
        {
            
            gameOver = true;
        }
    }
}
