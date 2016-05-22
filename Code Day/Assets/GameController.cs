using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	// Use this for initialization
	public GameObject countDown;

	private Texture countDownText;
	private int secondsCount;

	void Start () 
	{
		secondsCount = 0;
		countDownText = countDown.GetComponent<Text>();

}
	
	Invoke("CountDown", 1F);
	InvokeRepeating("countTime", 5F, 1F);
}

void countTime()
{
	secondsCount += 1;
	Debug.Log(secondsCount);
}

void CountDown()
{
	LeanTween.scale(countDown, new Vector3(0F, 0F, 0F)).setEase(LeanTweenType.EaseInOut);
}

// Update is called once per frame
void Update () 
{

}