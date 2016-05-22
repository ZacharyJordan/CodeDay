using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

	// Use this for initialization
	private GameObject countDown;

	private Text countDownText;
	private int countingInt;

	private int secondsCount;

	void Start () 
	{
		secondsCount = 0;
		countDown = GameObject.Find("CountDown");
		countDownText = countDown.GetComponent<Text>();

		Invoke("easeIn", 1F);
		InvokeRepeating("countTime", 5F, 1F);

		Invoke("enemyOneAppear", 7F);

		countingInt = 3;

}

	void countTime()
{
	secondsCount += 1;
	Debug.Log(secondsCount);
}

	void enemyOneAppear()
	{
		LeanTween.scale(GameObject.Find("FirstEnemy"), new Vector3(1F, 1F, 1F), .7F).setEase(LeanTweenType.easeInOutCirc);

	}

void easeIn()
{
		LeanTween.scale(countDown, new Vector3(1F, 1F, 1F), .7F).setEase(LeanTweenType.easeInOutCirc);
		Invoke("easeOut", .7F);

}

	void easeOut()
	{
		LeanTween.scale(countDown, new Vector3(0F, 0F, 0F), .7F).setEase(LeanTweenType.easeInOutCirc);
		countingInt--;
		Invoke("changeText", .7F);
	}

	void changeText()
	{
		if(countingInt != 0)
		{
			countDownText.text = countingInt.ToString();

		}
		else 
		{
			countDownText.text = "Go!";
		}
		if(countingInt != -1)
		{
			Invoke("easeIn", 0F);
		}
	}

// Update is called once per frame
void Update () 
{

}
}