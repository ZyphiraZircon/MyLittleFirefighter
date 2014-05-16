#pragma strict

var cameraOutput : GUITexture; 
 
private var webcamTexture : WebCamTexture; 
private var devices : WebCamDevice[];
 
function Start () { 
    devices = WebCamTexture.devices; 
    webcamTexture = new WebCamTexture(); 
    if(devices.length > 0){ 
       webcamTexture.deviceName = devices[0].name; 
       webcamTexture.requestedWidth = Screen.width; 
       webcamTexture.requestedHeight = Screen.height; 
       var width = webcamTexture.requestedWidth; 
       var height = webcamTexture.requestedHeight;
       var centerX = (width/2) *-1;
       var centerY = (height/2) * -1;
       cameraOutput.pixelInset = Rect(centerX, centerY, width, height);
       cameraOutput.texture = webcamTexture; 
       webcamTexture.Play(); 
    } 
}
function OnGUI () { 
    if (WebCamDevice == null){ 
       GUI.Label(Rect(10,10,65,25),"NO ACTIVE CAMERA"); 
    }
}