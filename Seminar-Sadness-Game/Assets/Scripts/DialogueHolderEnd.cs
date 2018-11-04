using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueHolderEnd : MonoBehaviour
{

    public string dialogue;

    private DialogueManagerEnd dMan;

    public string[] dialogueLines;
    public string[] dialogueLinesfinished;

    private PlayerFlags thePlayer;

    // Use this for initialization
    void Start()
    {
        dMan = FindObjectOfType<DialogueManagerEnd>();
        thePlayer = FindObjectOfType<PlayerFlags>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            if (Input.GetKeyUp(KeyCode.E) && thePlayer.code == true)
            {
                // dMan.ShowBox(dialogue);

                if (!dMan.dialogActive)
                {
                    print("last");
                    dMan.dialogLines = dialogueLinesfinished;
                    dMan.currentLine = 0;
                    dMan.ShowDialogue();

                }
            }
        }
    }
}
