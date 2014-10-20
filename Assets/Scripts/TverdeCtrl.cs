using UnityEngine;
using System.Collections;

public class TverdeCtrl : MonoBehaviour {
	// Use this for initialization
	float random = Random.Range (-10,10);
	void Start () {
		transform.rigidbody2D.AddTorque(random);
	}
	
	// Update is called once per frame
	void Update () {
	
	 if(transform.position.y < -4f) {//Destruir en las y
	 	Destroy(gameObject);
	 }
	 else if (transform.position.x > 3.5f || transform.position.x < -3.5f) {//Destruir en las x
	 	Destroy(gameObject);
	 }
	}
}
