using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {



    public float speed, acceleration, hp, rage;

    Rigidbody player;

	// Use this for initialization
	void Start ()
    {

        player = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {

       
        var MoveHorizontal = Input.GetAxis("Horizontal");
        var MoveVertical = Input.GetAxis("Vertical");

        player.velocity = new Vector3(MoveHorizontal, MoveVertical, 0) * speed;

    }
}
