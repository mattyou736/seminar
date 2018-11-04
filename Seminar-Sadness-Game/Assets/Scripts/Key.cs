using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    private PlayerFlags thePlayer;
    public GameObject key;

    // Use this for initialization
    void Start () {
        thePlayer = FindObjectOfType<PlayerFlags>();
    }
	
	// Update is called once per frame
	void Update () {
        
    }


    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                thePlayer.key = true;
                Destroy(key);
                Destroy(gameObject);

            }
        }
    }
}
