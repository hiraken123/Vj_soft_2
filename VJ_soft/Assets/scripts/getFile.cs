using UnityEngine;
using System.Collections;

public class getFile : MonoBehaviour {
	
	private string targetFile ="C:/Users/hira/Documents/test_img";
	public GameObject cursorObj; 
	
	// Use this for initialization
	void Start () {
		showFile(targetFile);
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void showFile(string target){
		
	string[] files = System.IO.Directory.GetFileSystemEntries(target);
	int i =0;
		
    foreach (string s in files) {
			GameObject instanse = (GameObject)Instantiate(cursorObj,Vector3.zero,Quaternion.identity);
			Vector3 p;
			p.y = this.transform.position.y +1.1f*i;
			p.x = this.transform.position.x;
			p.z = 0.0f;
			instanse.transform.position = p;
			
			string[] imageSplit = s.Split('/');
			
			int count = imageSplit.Length-1;
			
			string imageName = imageSplit[count];
			
			
			TextMesh detailText = instanse.transform.FindChild("detaile").GetComponent<TextMesh>();
			detailText.text = i.ToString()+":"+imageName;
			
			tap_obj _tap_obj = instanse.GetComponent<tap_obj>();
			_tap_obj.filePass = "file:///"+ s;
			
			i++;
    }
		
	}
	
}
