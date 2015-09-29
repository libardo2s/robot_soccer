using UnityEngine;
using System.Collections;

public class ColisionBalon : MonoBehaviour {
	//private Rigidbody rb;
	private float force;
	
	void Start(){
		///rb = GetComponent<Rigidbody>();
		force = 0;
	}
	
	void Update(){
		transform.position = transform.position + Vector3.back * force;
	}
	
	void OnTriggerEnter(Collider other) {
            //set the velocity, so you can move
			 force = 1f;
			 
    }
	
	void OnTriggerExit(Collider other) {
            //set the velocity, so you can move
			 force = 0;
    }
}
