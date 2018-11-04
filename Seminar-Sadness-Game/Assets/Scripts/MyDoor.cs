using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDoor : MonoBehaviour {

    private PlayerFlags thePlayer;
    public GameObject door;

    // Use this for initialization
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerFlags>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player" && thePlayer.key == true)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                Destroy(gameObject);
            }
        }
    }
}
