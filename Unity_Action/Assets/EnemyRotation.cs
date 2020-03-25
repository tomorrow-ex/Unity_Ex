using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotation : MonoBehaviour {
    public float MovingDistance = 8;
    private float StartPos;
	// Use this for initialization
	void Start () {
        StartPos = 4;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, 1);
        transform.position = new Vector3(StartPos - Mathf.PingPong(Time.time * 2.0f, MovingDistance), 1.3f, 40);
    }
}
