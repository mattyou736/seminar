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

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player" && thePlayer.code == true)
        {
            print("first");
            if (Input.GetKeyUp(KeyCode.E) )
            {
                // dMan.ShowBox(dialogue);
                print("middle");
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
