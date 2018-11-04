using UnityEngine;
using System.Collections;

public class DialogueHolder : MonoBehaviour
{
    public string dialogue;

    private DialogueManager dMan;

    public string[] dialogueLines;

    private PlayerFlags thePlayer;

    // Use this for initialization
    void Start ()
    {
        dMan = FindObjectOfType<DialogueManager>();
        thePlayer = FindObjectOfType<PlayerFlags>();
    }
	
	// Update is called once per frame
	void Update ()
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
