using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StageClearCount : MonoBehaviour 
{
	public GameObject ClearPopup;

	private GameManagerScript GMS; // 카운터다운 이후 타이머 시작

	public Text TimeText;
	public float TimeStamp;
	public bool UsingTimer = false;

	// Use this for initialization
	void Start () {
		GMS = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
		SetTimer(305);
	}
	
	// Update is called once per frame
	void Update () {
			if (UsingTimer)
				SetUIText();		
	}

	public void SetTimer(float time)
	{
		if (UsingTimer)
			return;
		TimeStamp = Time.time + time;
		UsingTimer = true;
	}

    //해당 시간을 텍스트뷰에 set해.
    public void SetUIText()
	{
		if (GMS.counterDownDone == true)
		{
			float timeLeft = TimeStamp - Time.time;
			if (timeLeft <= 0)
			{
				FinishAction();
				return;
			}
			float hours;
			float minutes;
			float seconds;
			float miniseconds;
			GetTimeValues(timeLeft, out hours, out minutes, out seconds, out miniseconds);

			if (hours > 0)
				TimeText.text = string.Format("{0}:{1}", hours, minutes);
			else if (minutes > 0)
				TimeText.text = string.Format("{0}:{1}", minutes, seconds);
			else
				TimeText.text = string.Format("{0}:{1}", seconds, miniseconds);
		}
	}

    //시간에 대한 수학적 공식
    public void GetTimeValues(float time, out float hours, out float minutes, out float seconds, out float miniseconds)
	{
		
			hours = (int)(time / 3600f);
			minutes = (int)((time - hours * 3600) / 60f);
			seconds = (int)((time - hours * 3600 - minutes * 60f));
			miniseconds = (int)((time - hours * 3600 - minutes * 60f - seconds) * 100);

	}

    //0초가 되었을때 발생할 이벤트
	public void FinishAction()
	{
		Debug.Log("Boom");
		TimeText.text = "00:00";
		UsingTimer = false;
		//gameover
		ClearPopup.SetActive(true);
	}
}
