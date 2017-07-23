using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnBall : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("ReturnTheFuckingBall") == 1)
        {
            transform.position = new Vector3(0, 0.5f, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
            GetComponent<Rigidbody>().isKinematic = false;
        }
	}
}
