using UnityEngine;
using System.Collections;

public class PutOutFire : MonoBehaviour {
	
	float rate = -0.025f;
	float smokeCooldown = 2f;
	ParticleEmitter fireBase;
	ParticleEmitter fireHead;
	ParticleEmitter smoke;
	
	// Use this for initialization
	void Start () {
		fireBase = transform.Find("OuterCore").GetComponent<ParticleEmitter>();
		fireHead = transform.Find("InnerCore").GetComponent<ParticleEmitter>();
		smoke = transform.Find("Smoke").GetComponent<ParticleEmitter>();
	}
	
	// Update is called once per frame
	void Update () {
		//smoke.maxSize = 1.5f;
		//smoke.minSize = 1.5f;
		smoke.maxSize = 1.5f;
		smoke.minSize = 1.5f;
		
		if (smokeCooldown > 0){
			smokeCooldown -= 0.05f;
			smoke.maxSize = 4.5f;
			smoke.minSize = 4.5f;
		}
		
		if (fireBase.maxSize <= 0 && fireHead.maxSize <= 0){
			KillSelf();
		}
		
	}
	
	void OnCollisionEnter(Collision collision) {
		
		if (fireBase.maxSize > 0 && fireBase.minSize > 0){
			fireBase.maxSize += rate;
			fireBase.minSize += rate;
		}
		
		
		if (fireHead.maxSize > 0 && fireHead.minSize > 0){
			fireHead.maxSize += rate;
			fireHead.minSize += rate;
		}
		
		
		smokeCooldown = 2f;
		
	}
	
	void KillSelf() {
		Destroy (gameObject);
	}
	
}
