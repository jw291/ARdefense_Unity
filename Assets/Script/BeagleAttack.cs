using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BeagleAttack : MonoBehaviour
{
	//attackrange 범위 내에 존재하는 적의 피가 감소한다
	//transform.position이 주어
	//몬스터가 큐브범위 안에 들어가면 몬스터의 피가 감소한.
	//transform.position이 몬스터 attackrange는 Transform attackrange

	public Image healthbar;

	bool enable = true;
	public float LineOfSight = 0.1f;
	private Animator animator;
	public GameObject enemy;
	// Use this for initialization
	public int starthealth = 100;// static으로 하면 다 죽어버림 디폴트로 해야 각각의 오브젝트가 체력 100을 가짐
	public int health;

	public static int statichealth; // 다른 스크립트에서도 접근 할 수 있는 피
	public float LineOfSight2;

	public Animator friend;
	void Start()
	{
		animator = enemy.GetComponent<Animator>();
		InvokeRepeating("attack", 1, 1);
		InvokeRepeating("friendattack",0.2f,2);
		health = starthealth;

	}

    void friendattack()
	{
		if(!FriendBuy.instantiateparent)
		{
			Debug.Log("아직 안샀음");
		}
		else
		{
			friend = FriendBuy.instantiateparent.GetComponent<Animator>();			
			if ((Vector3.Distance(transform.position, FriendBuy.instantiateparent.transform.position) < LineOfSight2))
			{
				health -= 20;
				healthbar.fillAmount -= 0.2f;
			}
			else { Debug.Log("아직 friend의 바깥에 있음"); }
		}
	}
	// Update is called once per frame
	void attack()
	{
		
			if (!Attackrangeshow.instantiateattackrange)
			{
				//Debug.Log("아직 생성 안함");
			}
			else
			{
				Debug.Log("생성함");
			if ((Vector3.Distance(transform.position, Attackrangeshow.instantiateattackrange.transform.position) < LineOfSight))//몬스터와 타겟간의 거리가 1.0f미만이면
				{ //이 범위 안에 들어온 적의 피가 깎인다
				  //Debug.Log("몬스터가 큐브 범위 안에 들어감");
				health -= 50; // 50이 곧 비글의 데미지a
				healthbar.fillAmount -=  0.5f;// 호출 될때 마다 체력이 감소한	
				}

				else
				{//몬스터와 타겟간의 거리가 1.0f 이상이면 계속 타겟을 향해 달려간다
				 //Debug.Log("몬스터가 큐브 바깥에 있음");
				}
			}                    
	}

	void Update()
	{
		statichealth = health;
		if(health <= 0 && enable){
			Debug.Log("죽음");
			transform.Translate(0.0f * Vector3.forward * Time.deltaTime);
			DeadAnimation();
			InvokeRepeating("Dead", 2, 1);          
			enable = false;
			GoldBar.nowgold += 10;      
		}
	}

    void Dead()
	{
		Destroy(gameObject);
	}
    
	void DeadAnimation(){
		animator.SetTrigger("isDie");
	}

}
