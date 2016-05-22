using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

	// Use this for initialization
	public GameObject FirstEnemy;
	private GameObject countDown;

	private GameObject firstSpikes;
	private Vector2 firstSpikesPos; 

	private Text countDownText;
	private int countingInt;

	private int secondsCount;

	void Start () 
	{
		firstSpikes = GameObject.Find("Spikes4");
		firstSpikesPos = firstSpikes.GetComponent<Transform>().position;

		secondsCount = 0;
		countDown = GameObject.Find("CountDown");
		countDownText = countDown.GetComponent<Text>();

		Invoke("easeIn", 1F);
		InvokeRepeating("countTime", 5F, 1F);

		Invoke("enemyOneAppear", 6F);

		countingInt = 3;

}

	void countTime()
{
	secondsCount += 1;
	
		if(secondsCount > 10)
		{
			Debug.Log("Wow!");
			firstSpikesSpawn();
		}
	
}

	void firstSpikesSpawn()
	{
		LeanTween.move(firstSpikes, firstSpikesPos, .3F).setEase(LeanTweenType.easeInOutCirc);
	}

	void enemyOneAppear()
	{
		FirstEnemy.SetActive(true);
		LeanTween.scale(FirstEnemy, new Vector3(2F, 2F, 2F), .5F).setEase(LeanTweenType.easeInOutCirc);
		Invoke("StartFirst", .6F);

	}

	void StartFirst()
	{
		FirstEnemy.GetComponent<easyEnemy>().startMovement();
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
			Invoke("StartMovement", 1.1F);
		}
		if(countingInt != -1)
		{
			Invoke("easeIn", 0F);
		}
	}

	void StartMovement()
	{
		GameObject.Find("PlayerOne").GetComponent<PlayerMovement>().startMoving();
	}

// Update is called once per frame
void Update () 
{

}
}