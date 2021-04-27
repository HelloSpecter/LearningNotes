using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstacleMove : MonoBehaviour {

    float t;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float c=Mathf.PingPong(t, 20f);
        transform.Translate
	}
}
