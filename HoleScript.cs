using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HoleScript : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other) 
	{
		if (other.tag == "Ball") 
		{
			Destroy (other.gameObject);
            Debug.Log("Hit!");
            GetComponent<AudioSource>().Play ();
            	GameControl.control.lastStrokes[Application.loadedLevel] = GameControl.control.strokes;
            	GameControl.control.lastDistance[Application.loadedLevel] = GameControl.control.totalDistance;
            GameControl.control.isHoleOver = true;

		} 

		//Update Best Rounds
		if (GameControl.control.lastStrokes [Application.loadedLevel] < GameControl.control.bestStrokes [Application.loadedLevel]
		    || GameControl.control.bestStrokes [Application.loadedLevel] == 0) 
		{
			GameControl.control.bestStrokes[Application.loadedLevel] = (GameControl.control.lastStrokes [Application.loadedLevel]);
		}

		if (GameControl.control.lastDistance [Application.loadedLevel] > GameControl.control.highestDistance [Application.loadedLevel]
		    && GameControl.control.lastStrokes [Application.loadedLevel] <= GameControl.control.bestStrokes [Application.loadedLevel]) 
		{
			GameControl.control.highestDistance[Application.loadedLevel] = (GameControl.control.lastDistance [Application.loadedLevel]);
		}

		if (GameControl.control.lastDistance [Application.loadedLevel] < GameControl.control.lowestDistance [Application.loadedLevel]
		    || GameControl.control.lowestDistance [Application.loadedLevel] == 0) 
		{
			GameControl.control.lowestDistance[Application.loadedLevel] = (GameControl.control.lastDistance [Application.loadedLevel]);
		}



	}

}