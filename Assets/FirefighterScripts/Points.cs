using UnityEngine;
using System.Collections;

public class Points : MonoBehaviour {
	public FlameManagerScript manager;
	// Use this for initialization
	void Start () {
		this.guiText.material.color = Color.black;
	}
	
	// Update is called once per frame
	void Update () {
		this.guiText.text = "Points:" + manager.points.ToString();
	}
}
