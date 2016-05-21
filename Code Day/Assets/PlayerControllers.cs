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

	private float playerOneXSpeed;
	private float playerOneYSpeed;

	// Use this for initialization
	void Start () 
	{
		playerOnePos = playerOne.GetComponent<Rigidbody2D>().position;
		playerTwoPos = playerTwo.GetComponent<Rigidbody2D>().position;

		playerOneXSpeed = 0;
		playerOneYSpeed = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		movementControl();
	}

	void movementControl()
	{
		/*
		 * Vector3 pos = cLight.transform.position;
		pos.x += Input.GetAxis ("Horizontal") * 30f * Time.deltaTime;
		pos.y += Input.GetAxis ("Vertical") * 30f * Time.deltaTime;
		cLight.transform.position = pos;
		*/



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

		if(Input.GetKey(KeyCode.LeftArrow))
		{
			playerTwoPos.x -= movementSpeed;
		}
		else if(Input.GetKey(KeyCode.RightArrow))
		{
			playerTwoPos.x += movementSpeed;
		}

		if(Input.GetKey(KeyCode.UpArrow))
		{
			playerTwoPos.y += movementSpeed;
		}
		else if(Input.GetKey(KeyCode.DownArrow))
		{
			playerTwoPos.y -= movementSpeed;
		}
			
		playerOne.GetComponent<Rigidbody2D>().position = playerOnePos;
		playerTwo.GetComponent<Rigidbody2D>().position = playerTwoPos;

	}
}
