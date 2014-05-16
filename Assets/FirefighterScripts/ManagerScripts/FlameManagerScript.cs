using UnityEngine;
using System.Collections;

public class FlameManagerScript : MonoBehaviour {
	public GameObject flamePrefab;
	int distance = 7;
	GameObject flame1 = null;
	GameObject flame2 = null;
	GameObject flame3 = null;
	GameObject flame4 = null;
	GameObject flame5 = null;
	public int points = 0;
	
	
	void Start () {
		Vector3 randomUnit = RandomLocation() * distance;
		flame1 = (GameObject)Instantiate (flamePrefab, transform.position + randomUnit, flamePrefab.transform.rotation);
		randomUnit = RandomLocation() * distance;
		flame2 = (GameObject)Instantiate (flamePrefab, transform.position + randomUnit, flamePrefab.transform.rotation);
		randomUnit = RandomLocation() * distance;
		flame3 = (GameObject)Instantiate (flamePrefab, transform.position + randomUnit, flamePrefab.transform.rotation);
		randomUnit = RandomLocation() * distance;
		flame4 = (GameObject)Instantiate (flamePrefab, transform.position + randomUnit, flamePrefab.transform.rotation);
		randomUnit = RandomLocation() * distance;
		flame5 = (GameObject)Instantiate (flamePrefab, transform.position + randomUnit, flamePrefab.transform.rotation);
	}
	

	void Update () {
		if (flame1 == null){
			Vector3 randomUnit = RandomLocation() * distance;
			flame1 = (GameObject)Instantiate (flamePrefab, transform.position + randomUnit, flamePrefab.transform.rotation);
			points += 1;
		}
		if (flame2 == null){
			Vector3 randomUnit = RandomLocation() * distance;
			flame2 = (GameObject)Instantiate (flamePrefab, transform.position + randomUnit, flamePrefab.transform.rotation);
			points += 1;
		}
		if (flame3 == null){
			Vector3 randomUnit = RandomLocation() * distance;
			flame3 = (GameObject)Instantiate (flamePrefab, transform.position + randomUnit, flamePrefab.transform.rotation);
			points += 1;
		}
		if (flame4 == null){
			Vector3 randomUnit = RandomLocation() * distance;
			flame4 = (GameObject)Instantiate (flamePrefab, transform.position + randomUnit, flamePrefab.transform.rotation);
			points += 1;
		}
		if (flame5 == null){
			Vector3 randomUnit = RandomLocation() * distance;
			flame5 = (GameObject)Instantiate (flamePrefab, transform.position + randomUnit, flamePrefab.transform.rotation);
			points += 1;
		}
	
	}
	
	Vector3 RandomLocation(){
		Vector3 location = new Vector3();
		location.z = Random.Range(-1, 1);
		float rxy = Mathf.Sqrt(1 - location.z*location.z);
		float phi = Random.Range(0,2*Mathf.PI);
		location.x = rxy * Mathf.Cos(phi);
		location.y = rxy * Mathf.Sin(phi);
		return location;
	}
	
}
