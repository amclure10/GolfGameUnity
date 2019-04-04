using UnityEngine;
using System.Collections;

public class HitScript : MonoBehaviour {

	private Vector2 ballPosition;
	private Vector2 releasePosition;
	private bool didMouseDown;
	private bool didMouseUp;
	public float forceMulitplier;
	public float totalDistance;
	public int strokes;
	private float ballRadius;


	void ResetMouse ()
	{
		didMouseUp = false;
		didMouseDown = false;
	}

	void Start ()
	{
		ResetMouse();
		ballRadius = 0.5f;
		ballPosition = gameObject.transform.position;
		totalDistance = 0f;
		strokes = 0;
	}

	void OnMouseDown()  // when user presses down mouse button
	{
       Debug.Log("Mouse is down");
        ballPosition = gameObject.transform.position;
        didMouseDown = true;
	}

	void OnMouseUp()   // when user releases mouse button
	{
        Debug.Log("Mouse is up");

        releasePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		didMouseUp = true;		
	}

	void Update ()
	{
        //&& (Vector2.Distance(ballPosition, releasePosition) > ballRadius)
        //IF the mouse button was clicked inside and then outside of the ball's raius then add force
        if ((didMouseUp && didMouseDown ))
		{
            GetComponent<Rigidbody2D>().AddForce ((ballPosition - releasePosition) * forceMulitplier);
			ResetMouse();
			GameControl.control.strokes++;
			var gameInst = GameObject.Find("Instructions");
			Destroy(gameInst);
		}

		Vector2 currentPosition = gameObject.transform.position;

		if (ballPosition != currentPosition) 
		{
			GameControl.control.totalDistance += Vector2.Distance(currentPosition,ballPosition);
			ballPosition = currentPosition;
		}

	}

}
