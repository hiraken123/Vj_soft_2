using UnityEngine;
using System.Collections;

public class tap_obj : MonoBehaviour {

	public string filePass;
	public MovieTexture movieTexture;
	
	IEnumerator Start(){
		WWW www = new WWW(filePass);
		yield return www;
		/*
		movieTexture = www.movie;
		renderer.material.mainTexture = movieTexture;
		movieTexture.loop = true; // ループ
    	movieTexture.Play();
		*/
		
		renderer.material.mainTexture = new Texture2D(256,256);
		www.LoadImageIntoTexture(renderer.material.mainTexture as Texture2D);
		
		
		
		
		
	}
	
	
	
	
}
