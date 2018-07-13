using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMainDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public GameObject ScreenPrefab;
	// Update is called once per frame
	void Update () {
		
	}

    void Set()
    {
        GameObject f = Instantiate(ScreenPrefab);
        f.transform.rotation = Quaternion.Euler(0,0,0);

    }
}
