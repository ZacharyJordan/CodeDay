using UnityEngine;
using System.Collections;

public class easyEnemy : MonoBehaviour {

	// Use this for initialization
	private string enemyDirectionX;
	private string enemyDirectionY;
	private Rigidbody2D myBody;
	private Vector2 movementSpeed;
	private bool startingMovement;

	void Start ()
	{
		enemyDirectionX = "left";
		enemyDirectionY = "up";
		movementSpeed = new Vector2(0, 0);
		startingMovement = false;

		myBody = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		enemyMovement();
	}

	public void startMovement()
	{
		startingMovement = true;
	}

	void enemyMovement()
	{
		if(startingMovement)
		{
			if(enemyDirectionX == "left")
			{
				movementSpeed.x = -4;	
			}
			else if(enemyDirectionX == "right")
			{
				movementSpeed.x = 4;
			}

			if(enemyDirectionY == "down")
			{
				movementSpeed.y = -4;
			}
			else if(enemyDirectionY == "up")
			{
				movementSpeed.y = 4;
			}

			myBody.MovePosition(myBody.position + movementSpeed * Time.deltaTime);
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if(coll.gameObject.tag == "topWall")
		{
			enemyDirectionY = "down";
		}
		else if(coll.gameObject.tag == "bottomWall")
		{
			enemyDirectionY = "up";
		}

		if(coll.gameObject.tag == "leftWall")
		{
			enemyDirectionX = "right";
		}
		else if(coll.gameObject.tag == "rightWall")
		{
			enemyDirectionX = "left";
		}
	}
}
