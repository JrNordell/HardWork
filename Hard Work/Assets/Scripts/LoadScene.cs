using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    BoxCollider2D bc;
    PolygonCollider2D playerCollider;

    public GameObject player;
    public string scenePath;
    public string door;
    public bool isLocked;

	// Use this for initialization
	void Start () {
        bc = GetComponent<BoxCollider2D>();
        playerCollider = player.GetComponent<PolygonCollider2D>();
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerPrefs.SetString("Door", door);
        SceneManager.LoadScene(scenePath);
    }
}
