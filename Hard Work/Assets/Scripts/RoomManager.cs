using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour {
    public OverRoom currentRoom;
    public static RoomManager Instance;


    private void Awake()
    {
        Instance = this;
    }
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setRoom(OverRoom room)
    {
        currentRoom = room;
        //GameCamera.Instance.setRoom(currentRoom);
    }

    public void onEnter(OverRoom room)
    {
        currentRoom = room;
        //GameCamera.Instance.setRoom(currentRoom);
    }
}
