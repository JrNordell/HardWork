 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverRoom : MonoBehaviour {

    public GameObject currentRoom;

	// Use this for initialization
	void Start () {
        //RoomManager.Instance.setRoom(this);
	}
	
	// Update is called once per frame
	void Update () {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            RoomManager.Instance.onEnter(this);
        }
    }
}
