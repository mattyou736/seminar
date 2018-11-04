using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogHolderCode : MonoBehaviour {

    public string dialogue;

    private dialogManagerCode dMan;

    public string[] dialogueLines;

    private PlayerFlags thePlayer;


    // Use this for initialization
    void Start()
    {
        dMan = FindObjectOfType<dialogManagerCode>();
        thePlayer = FindObjectOfType<PlayerFlags>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                // dMan.ShowBox(dialogue);

                if (!dMan.dialogActive)
                {
                    thePlayer.Move = false;
                    dMan.dialogLines = dialogueLines;
                    dMan.currentLine = 0;
                    dMan.ShowDialogue();
                }
            }
        }
    }
}
