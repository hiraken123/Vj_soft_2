using UnityEngine;
using System.Collections;

public class selectedObj : MonoBehaviour {
	
	public static GameObject selectedGameObject;
	public GameObject mainScreen;
	/*
	private Texture mainScreentexture;
	private Texture targetTexture;
	private MovieTexture mainMovieTexture;
	private MovieTexture targetMovieTexture;
	*/

	void Start () {
		mainScreen = GameObject.Find("main_screen");
		//subView = Camera.
	}
	
	void Update () {
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		
		if(Physics.Raycast(ray,out hit,100)&&Input.GetButtonDown("Fire1")){
			selectedGameObject = hit.collider.gameObject;
			//tap_obj _tap_obj = selectedGameObject.GetComponent<tap_obj>();
			
			mainScreen.renderer.material.SetTexture("_MainTex",selectedGameObject.renderer.material.GetTexture("_MainTex"));
			
			
			
		}else{
			selectedGameObject = null;
		}
	
	}
	
	
	
	
	
	
	
}
