using UnityEngine;
using System.Collections;

public class PlayerControllers : MonoBehaviour {

	public float movementSpeed;

	public GameObject playerOne;
	public GameObject playerTwo;
	public GameObject playerThree;
	public GameObject playerFour;

	private Vector2 playerOnePos;
	private Vector2 playerTwoPos;
	private Vector2 playerThreePos;
	private Vector2 playerFourPos;

	// Use this for initialization
	void Start () 
	{
		playerOnePos = GetComponent<Transform>().position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		movementControl();
	}

	void movementControl()
	{
		if(Input.GetKey(KeyCode.A))
		{
			playerOnePos.x -= movementSpeed;
		}
		else if(Input.GetKey(KeyCode.D))
		{
			playerOnePos.x += movementSpeed;
		}

		if(Input.GetKey(KeyCode.W))
		{
			playerOnePos.y += movementSpeed;
		}
		else if(Input.GetKey(KeyCode.S))
		{
			playerOnePos.y -= movementSpeed;
		}

		playerOne.GetComponent<Transform>().position = playerOnePos;
		playerTwo.GetComponent<Transform>().position = playerTwoPos;

	}
}
