using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goat_attack : MonoBehaviour {
	private Animator animator;
	public Transform house;
	float LineOfSight = 28.0f;
	// Use this for initialization
	void Start () {
		InvokeRepeating("attack", 2, 3);
		animator = gameObject.GetComponent<Animator>();
	}


	void attack()
	{
		if (Vector3.Distance(transform.position, house.position) > 10.0f)
		{
			if ((Vector3.Distance(transform.position, house.position) < LineOfSight))//몬스터와 타겟간의 거리가 30.0f미만이면
			{ //몬스터가 멈추고 공격을 한다
				//Debug.Log("hit!!!!");
				House_Health.health -= 1;
				animator.SetBool("isRunning", true);

			}
			else
			{
				//Debug.Log("out target");
			}
		}
		//transform.LookAt(mTarget.position);
		//transform.Translate(0.0f, 0.0f, mSpeed * Time.deltaTime);
	}
}
