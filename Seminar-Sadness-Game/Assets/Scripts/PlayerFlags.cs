using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlags : MonoBehaviour {

    public bool Move = true;

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
}
