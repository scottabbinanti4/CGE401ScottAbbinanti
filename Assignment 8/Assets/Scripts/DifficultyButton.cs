/*
 * Scott Abbinanti 
 * DifficultyButton
 * Assignment 8
 * Controls difficulty buttons on menu
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button button;

    private GameManager gm;

    public float difficulty;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        button.onClick.AddListener(SetDifficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDifficulty()
    {
        gm.StartGame(difficulty);
    }
}
