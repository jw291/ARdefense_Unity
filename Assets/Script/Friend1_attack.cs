using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Friend1_attack : MonoBehaviour {
	//주어는 친구
	public float LineofSight;
	public float LineofSight2;
	// Use this for initialization

	private Animator animator;

    public GameObject f1instantiateattackrange;
    
	private bool particle = false;
    
	private BeagleAttack ba;

	private Animator enemyanimator;
	void Start () {
		animator = gameObject.GetComponent<Animator>();
		ba = Spawner.cloneenemy.GetComponent<BeagleAttack>();
		enemyanimator = Spawner.cloneenemy.GetComponent<Animator>();
	}

    
	void Update () 
	{
		//Vector3.Distance안에 들어오면 그 적 LookAt  
		if (!Spawner.cloneenemy)
		{
			//적이 없는데 참조하게 되면 정지돼버림a
			animator.Play("BeagleIdle");
		}
		else if (Vector3.Distance(transform.position, Spawner.cloneenemy.transform.position) <= LineofSight)
		{
           
			//공격을 한다.  
			//invoke로 attack호출
			//위치가 변할때마다 업데이트되니까 계속 Play됌
			transform.LookAt(Spawner.cloneenemy.transform.position);
			Attack();
         
        }
		else if(Vector3.Distance(transform.position, Spawner.cloneenemy.transform.position) > LineofSight && Vector3.Distance(transform.position, Spawner.cloneenemy.transform.position) <= LineofSight2)
		{
			animator.SetBool("IdleRun",true);
			animator.SetBool("AttackRun",true);
            transform.LookAt(Spawner.cloneenemy.transform.position);
            transform.Translate(13.0f * Vector3.forward * Time.deltaTime);
        }

	}

	void Attack()
	{
		animator.Play("BeagleAggressiveAttack2");

	}
   
	void DeadAnimation(){
		enemyanimator.SetTrigger("isDie");
	}
    void Dead()
	{
		Destroy(Spawner.cloneenemy);
	}

}
