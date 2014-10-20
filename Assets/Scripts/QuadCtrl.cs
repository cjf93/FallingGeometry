using UnityEngine;
using System.Collections;

public class QuadCtrl : MonoBehaviour {
	
	float lastrx;
	int puntuacion;
	public GUIText puntuacionGui;
	// Use this for initialization
	void Start () {
		puntuacion = 0;
		puntuacionGui.text = "Points: " + puntuacion.ToString();
		//GameObject instance = Instantiate(Resources.Load("TVerde"), pos, Quaternion.identity) as GameObject;
		InvokeRepeating("SpawnThings", 0.8f, 0.8f);//Invoca al spawneador cada z tiempo	
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	void SpawnThings() {
		float rx;
		if(lastrx < 0) {
			rx =  Random.Range(0f, 2f);
		}
		else {rx =  Random.Range(-2f, 0f);}
		Vector3 pos = new Vector3(rx,6,-2);
		float spawn =  Random.Range(0, 4);
		
		if (spawn == 0) {
			GameObject instance = Instantiate(Resources.Load("TVerde"), pos, Quaternion.identity) as GameObject;
		}
		if (spawn == 1) {
			GameObject instance = Instantiate(Resources.Load("TAmarillo"), pos, Quaternion.identity) as GameObject;
		}
		if (spawn == 2) {
			GameObject instance = Instantiate(Resources.Load("TAzul"), pos, Quaternion.identity) as GameObject;
		}
		if (spawn == 3) {
			GameObject instance = Instantiate(Resources.Load("TRojo"), pos, Quaternion.identity) as GameObject;
		}	
		lastrx = rx;
	}
}		