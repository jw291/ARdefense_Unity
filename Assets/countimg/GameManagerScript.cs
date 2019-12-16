using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManagerScript : MonoBehaviour {
	public bool counterDownDone = false;
	public GameObject CountDownImage;
   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(counterDownDone)
		{
			CountDownImage.SetActive(false);
		}
	}
}
