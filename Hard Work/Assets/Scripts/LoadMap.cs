using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMap : MonoBehaviour {

    public GameObject player;
    public int offsetX, offsetY;

	void Start () {
        string door;
        if (PlayerPrefs.HasKey("Door")){
            door = PlayerPrefs.GetString("Door");
            GameObject[] doors = GameObject.FindGameObjectsWithTag("Door");
            
            foreach(GameObject spot in doors)
            {
                if (door.Equals(spot.name))
                {
                    player.transform.position = new Vector2(spot.transform.position.x + offsetX, spot.transform.position.y + offsetY);
                }
            }
        }
        PlayerPrefs.SetString("Scene", SceneManager.GetActiveScene().name);
	}
	


	void Update () {
		
	}
}
