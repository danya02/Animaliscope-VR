using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyLoc : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public Transform target;
	// Update is called once per frame
	void Update () {
        gameObject.transform.position = target.position;
	}
}
