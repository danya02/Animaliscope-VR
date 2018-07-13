using UnityEngine;

public class SlowRotivator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Rotate(0, 0.01f, 0);
	}
}
