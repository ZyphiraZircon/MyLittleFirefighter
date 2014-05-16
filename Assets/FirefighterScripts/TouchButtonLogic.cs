using UnityEngine;
using System.Collections;

public class TouchButtonLogic : MonoBehaviour {

	void Update () 
	{
		//is there a touch on screen?
		if (Input.touches.Length <= 0)
		{
			//if no touches
		}
		else
		{
			for (int i = 0; i < Input.touchCount; ++i)
			{
				if (this.guiTexture.HitTest(Input.GetTouch(i).position))
				{
					if (Input.GetTouch(i).phase == TouchPhase.Began)
					{
						this.SendMessage ("OnTouchBegin");
					}
					if (Input.GetTouch(i).phase == TouchPhase.Ended)
					{
						this.SendMessage ("OnTouchEnd");
					}
				}
			}
		}
			
	}
}
