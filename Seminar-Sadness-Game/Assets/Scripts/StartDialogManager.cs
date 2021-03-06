﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class StartDialogManager : MonoBehaviour
{

    public GameObject dBox;

    public Text dText;

    public bool dialogActive;

    public string[] dialogLines;

    public int currentLine;


    // Update is called once per frame
    void Update()
    {
        if (dialogActive && Input.GetKeyDown(KeyCode.E))
        {
            currentLine++;
        }

        if (currentLine >= dialogLines.Length)
        {
            dBox.SetActive(false);
            dialogActive = false;

            currentLine = 0;

            Application.LoadLevel("Lvl");
            
        }

        dText.text = dialogLines[currentLine];

    }

    public void ShowBox(string dialogue)
    {
        dialogActive = true;
        dBox.SetActive(true);
        dText.text = dialogue;
    }

    public void ShowDialogue()
    {
        dialogActive = true;
        dBox.SetActive(true);
        
    }
}
