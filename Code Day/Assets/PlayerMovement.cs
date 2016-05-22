using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	public Vector2 movementSpeed;
	private Rigidbody2D myBody;
	private bool movementActive;

	void Start () 
	{
		movementActive = false;
		myBody = gameObject.GetComponent<Rigidbody2D>();
	}

	public void startMoving()
	{
		movementActive = true;
	}

	// Update is called once per frame
	void Update () 
	{
		if(movementActive)
		{
			if(Input.GetKey(KeyCode.A))
			{
				movementSpeed.x = -8;	
			}
			else if(Input.GetKey(KeyCode.D))
			{
				movementSpeed.x = 8;
			}
			else
			{
				movementSpeed.x = 0;
			}

			if(Input.GetKey(KeyCode.S))
			{
				movementSpeed.y = -8;
			}
			else if(Input.GetKey(KeyCode.W))
			{
				movementSpeed.y = 8;
			}
			else 
			{
				movementSpeed.y = 0;
			}

			//if(Input.GetKeyUp()

			myBody.MovePosition(myBody.position + movementSpeed * Time.deltaTime);
		}
	}
}
