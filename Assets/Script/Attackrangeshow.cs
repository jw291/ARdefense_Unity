using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackrangeshow : MonoBehaviour {
	public GameObject attackrange;
	public GameObject attackpoint;
	public GameObject parent;
	public static GameObject instantiateattackrange;//static으로 한 이유 : instantiate로 만들어낸 gameobject는 prefabs가 아닌 clone이다
    //그래서 BeagleAttack 스크립트에서 지정해놓은 attackrange prefabs와 clone은 엄연히 다르기 때문에 거리 계산이 불가능하다
	//때문에 enable()에서 리턴받은 값을 전역 변수에 저장하고 이를 beagleAttack 스크립트에서 불러와 거리 계산을 하였다

	void Start(){
	}
	public void Enable(){
		instantiateattackrange = Instantiate(attackrange,attackpoint.transform.position,attackpoint.transform.rotation) as GameObject;
		instantiateattackrange.transform.SetParent(parent.transform);
	}
	public void Disable(){
		Destroy(instantiateattackrange);
	}
}
