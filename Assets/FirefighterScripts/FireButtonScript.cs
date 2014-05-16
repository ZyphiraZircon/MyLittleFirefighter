using UnityEngine;
using System.Collections;

public class FireButtonScript : TouchButtonLogic {
	public WaterSpawner spawner;
	void OnTouchBegin(){
		spawner.SetShooting(true);
	}
	
	void OnTouchEnd(){
		spawner.SetShooting(false);
	}
}
