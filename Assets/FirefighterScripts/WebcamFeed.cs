using UnityEngine;
using System.Collections;

public class WebcamFeed : MonoBehaviour {

	WebCamDevice[] cameras;
	WebCamTexture camfeed;
	
	public void Start()
	{
	  cameras = WebCamTexture.devices;
	
	  if ((cameras != null) && (cameras.Length > 0))
	  {
	    camfeed = new WebCamTexture(cameras[0].name, 640, 480, 30);
	 
	    camfeed.Play();
	
	    GameObject bgimg = GameObject.Find("Background Image");
	    bgimg.guiTexture.texture = camfeed;
	  }
	}
}
