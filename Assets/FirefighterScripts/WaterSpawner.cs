using UnityEngine;
using System.Collections;

public class WaterSpawner : MonoBehaviour {
	public GameObject waterPrefab;
	float waterspeedImpulse = 30f;
	bool shooting = false;
	
	void Start () {
	}
	

	void Update () {
		if (shooting == true){
			GameObject water = (GameObject)Instantiate (waterPrefab, transform.position + transform.forward - (0.75f * transform.up), transform.rotation);
			water.rigidbody.AddForce(transform.forward * waterspeedImpulse, ForceMode.Impulse);
		}
	}
	
	public void SetShooting(bool flag){
		shooting = flag;
	}
}
