using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlags : MonoBehaviour {

    public bool Move = true;
    public bool key, code;

    public GameObject interactSymbol;

    //rigidbody
    private Rigidbody RigidPlayer;

    // Use this for initialization
    void Start () {
        RigidPlayer = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (!Move)
        {
            RigidPlayer.velocity = Vector3.zero;
            return;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Holder")
        {
            interactSymbol.SetActive(true);
        }
        if (other.gameObject.tag == "Door" && key == true)
        {
            interactSymbol.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        interactSymbol.SetActive(false);
    }
}
