using UnityEngine;
using System.Collections;

public class WaterDeath : MonoBehaviour {
	
	float lifespan = 2.5f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		lifespan -= Time.deltaTime;
		if(lifespan <= 0) {
			KillSelf();
		}
		
	}
	
	void OnCollisionEnter(Collision collision) {
		Destroy (gameObject);
	}
	
	void KillSelf() {
		Destroy (gameObject);
	}
}
