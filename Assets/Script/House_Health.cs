using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class House_Health : MonoBehaviour {
	public GameObject failpopup;
	public Slider myhealthBar;
    public GameObject house;
	public GameObject explosion;
	public Text healthtext;
    
    public static int health = 100; //현재 피 상태
									//이 health변수는 다른 스크립트에서 Heath.health로 이용할 수 있다
									//ex) Heath.health -= 20; 이런식으로

	bool enable = true;

    void Start()
	{
		
	}

   
    // Update is called once per frame
    void Update()
    {
		myhealthBar.value = health;
		healthtext.text = myhealthBar.value.ToString() + "%";
		if (health <= 0 && enable)
        {
            Instantiate(explosion, house.transform.position, explosion.transform.rotation);//피가 0이 되면 explosion 모델이 나타난다           
            enable = false;
            Debug.Log("dead");
			InvokeRepeating("applicationquit", 2, 1);
		}   
	}

	void applicationquit()
	{
		failpopup.SetActive(true);      
	}
}
