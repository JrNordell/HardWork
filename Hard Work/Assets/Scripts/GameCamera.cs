using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCamera : MonoBehaviour {

    public PolygonCollider2D border;
    public GameObject player;

    private Vector3 offset;

    void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        //border.GetComponent<PolygonCollider2D>
        transform.position = player.transform.position + offset;
    }

}
