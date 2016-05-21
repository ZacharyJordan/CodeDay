using UnityEngine;
using System.Collections;

public class PlayerControllers : MonoBehaviour {

	public float movementSpeed;
	public float maxSpeed;
	public float Acceleration;
	public float Deceleration;

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
		playerOnePos = playerOne.GetComponent<Transform>().position;
		playerTwoPos = playerTwo.GetComponent<Transform>().position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		movementControl();
	}

	void movementControl()
	{
		playerOne.GetComponent<Rigidbody2D>().velocity = playerOne.GetComponent<Rigidbody2D>().velocity + playerOne.GetComponent<Rigidbody2D>().velocity.normalized * 10 * Time.deltaTime;
	}

	/*void movementControl()
	{
		Debug.Log (movementSpeed);
		if((Input.GetKey(KeyCode.D))&&(movementSpeed < maxSpeed))
		{
			movementSpeed = movementSpeed + Acceleration * Time.deltaTime;
			playerOnePos.x += movementSpeed;
		}
		else if((Input.GetKey(KeyCode.A))&&(movementSpeed > -maxSpeed))
		{
			movementSpeed = movementSpeed + Acceleration * Time.deltaTime;
			playerOnePos.x -= movementSpeed;
		}
		else
		{
			if(movementSpeed > Deceleration * Time.deltaTime)
				movementSpeed = movementSpeed - Deceleration * Time.deltaTime;
			else if(movementSpeed < -Deceleration * Time.deltaTime)
				movementSpeed = movementSpeed + Deceleration * Time.deltaTime;
			else
				movementSpeed = 0;
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

		playerOne.GetComponent<Transform>().position = playerOnePos;
		playerTwo.GetComponent<Transform>().position = playerTwoPos;

	}*/
}
