using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	private GameManagerScript GMS;
	public GameObject[] enemies;
	public Vector3 spawnValues;
	public float spawnWait;
	public float spawnMostWait;
	public float spawnLeastWait;
	public int startWait;
	public bool stop;
	int randEnemy;
	GameObject instantiatehealthbar;

	public static GameObject cloneenemy; //cloneobject를 구분하기 위해서
										 //friendattack스크립트에서 사용하고있다a
										 //startcouroutine으로 바꿔야겠다
										 //이유는 3개를 한번에 생성하다보니까 friend들이 마지막에 생성된 애만 따라간다
										 //하나 하나 ㅂ랜덤으로 뽑아야될 것 같다
	void Start()
	{
		GMS = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
		//InvokeRepeating("waitSpawner", 0.1f, 7f);
		StartCoroutine(waitSpawner());
	}

	void Update()
	{
			spawnWait = Random.Range(spawnLeastWait, spawnMostWait);		
	}

	IEnumerator waitSpawner()
	{
		yield return new WaitForSeconds(startWait);
		while (!stop)
		{
			randEnemy = Random.Range(0, 1);

			Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));

			if (GMS.counterDownDone == true)
			{
				cloneenemy = Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
			}
			yield return new WaitForSeconds(spawnWait);
		}
	}
}
