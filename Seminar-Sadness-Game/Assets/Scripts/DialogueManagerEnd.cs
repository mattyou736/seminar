﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManagerEnd : MonoBehaviour {

    public GameObject dBox;

    public Text dText;

    public bool dialogActive;

    public string[] dialogLines;

    public int currentLine;


    public int dialoguetime;


    public string newGameScene;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (dialoguetime >= 10)
        {
            dialoguetime = 10;
        }
        else
        {
            dialoguetime++;
        }

        if (dialogActive && Input.GetKeyUp(KeyCode.E) && dialoguetime >= 10)
        {
            currentLine++;
        }

        
        if (currentLine >= dialogLines.Length && dialoguetime >= 10)
        {
            dBox.SetActive(false);
            dialogActive = false;

            currentLine = 0;

            SceneManager.LoadScene(newGameScene);

        }

        dText.text = dialogLines[currentLine];

    }

    public void ShowDialogue()
    {
        dialoguetime = 0;
        dialogActive = true;
        dBox.SetActive(true);
    }

}
