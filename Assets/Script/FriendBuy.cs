using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendBuy : MonoBehaviour {

	public GameObject friend1;
	public GameObject friend2;
	public GameObject friend3;

	public GameObject friend1spawner;
	public GameObject friend2spawner;
	public GameObject friend3spawner;

	public GameObject parent;

	public Vector3 spawnValues;
    
	public static GameObject instantiateparent;

	private Vector3 spawnPosition;

    void Start()
	{
		spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));
	}
	public void Friend1buy()
	{
		if(GoldBar.nowgold >= 20f)
		{
			GoldBar.nowgold -= 20f;
			instantiateparent= Instantiate(friend1, spawnPosition + friend1spawner.transform.position, friend1spawner.transform.rotation);
			instantiateparent.transform.SetParent(parent.transform, true);
			instantiateparent.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
		}else
		{
			Debug.Log("강아지를 살 수 없습니다");
		}
		//만약 nowgold가 20이상이라면
		//nowgold -= 20 즉, 20원을 감소한다
        //강아지모델을 instantiate시킨다
        //스폰지역을 만들어 놓고 그 스폰지역에 instantiate시킨.
	}

    public void Friend2buy()
	{
		if (GoldBar.nowgold >= 40f)
        {
            GoldBar.nowgold -= 40f;
			instantiateparent = Instantiate(friend2, spawnPosition +friend2spawner.transform.position, friend2spawner.transform.rotation);
			instantiateparent.transform.SetParent(parent.transform, true);
            instantiateparent.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        }
        else
        {
            Debug.Log("강아지를 살 수 없습니다");
        }
		//-40
	}
    public void Friend3buy()
	{
		if (GoldBar.nowgold >= 60)
        {
            GoldBar.nowgold -= 60f;
            instantiateparent = Instantiate(friend3, spawnPosition + friend3spawner.transform.position, friend3spawner.transform.rotation);
			instantiateparent.transform.SetParent(parent.transform, true);
            instantiateparent.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        }
        else
        {
            Debug.Log("강아지를 살 수 없습니다");
        }
		//-60
	}
}
