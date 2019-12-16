using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtFollow : MonoBehaviour {

	public Transform mTarget;//타겟은 집
	float mSpeed = 10.0f;//몬스터가 집까지 달려가는 속도
	float LineOfSight = 28.0f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(BeagleAttack.statichealth);
		if (BeagleAttack.statichealth > 0)
		{
			if ((Vector3.Distance(transform.position, mTarget.position) < LineOfSight))//몬스터와 타겟간의 거리가 30.0f미만이면
			{ //몬스터가 멈추고 공격을 한다
			  //Debug.Log("in target");

			}
			else
			{//몬스터와 타겟간의 거리가 30.0f 이상이면 계속 타겟을 향해 달려간다
			 //Debug.Log("out target");
				transform.LookAt(mTarget.position);
				transform.Translate(mSpeed * Vector3.forward * Time.deltaTime);
			}
		}else if(BeagleAttack.statichealth <=0){
			Debug.Log("멈춰랏a");
			transform.Translate(0.0f * Vector3.forward * Time.deltaTime );
		}
		//transform.LookAt(mTarget.position);
		//transform.Translate(0.0f, 0.0f, mSpeed * Time.deltaTime);
	}
     
}
