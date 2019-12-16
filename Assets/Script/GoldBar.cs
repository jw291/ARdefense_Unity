using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GoldBar : MonoBehaviour {

	public static float nowgold;
	private float startgold = 0f;
	private float fullgold = 100f;
    
	public Image goldBar;
	public Text goldvalue;

	// Use this for initialization
	void Start () {
		nowgold = startgold;
	}
	
    void Update()
	{
		goldBar.fillAmount = nowgold / 100;
		goldvalue.text = nowgold.ToString() + "/100";
	}
}
