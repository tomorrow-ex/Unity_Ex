using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    public GameObject Player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float posx = Player.transform.position.x;
        float posy = Player.transform.position.y;
        float posz = Player.transform.position.z;

        transform.position = new Vector3(posx, posy + 10, posz - 10);
	}
}
