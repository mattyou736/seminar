using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject dBox;

    public Text dText;

    public bool dialogActive;

    public string[] dialogLines;

    public int currentLine;


    public int dialoguetime;

    private PlayerFlags thePlayer;

    // Use this for initialization
    void Start ()
    {
        thePlayer = FindObjectOfType<PlayerFlags>();
    }
	
	// Update is called once per frame
	void Update ()
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

            thePlayer.Move = true;
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
