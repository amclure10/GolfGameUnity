using UnityEngine;
using System.Collections;

public class HoleGUI : MonoBehaviour {

	void OnGUI ()
	{
		if (GameControl.control.isHoleOver == true) 
		{
			if(GUI.Button (new Rect (400, 200, 160, 40), "Retry this Hole"))
			{
				Application.LoadLevel(Application.loadedLevel);
				GameControl.control.isHoleOver = false;
			}
			if (Application.loadedLevel < (GameControl.control.totalNumberOfHoles - 1))
			{
				if(GUI.Button (new Rect (400, 250, 160, 40), "Next Hole"))
				{
					Application.LoadLevel(Application.loadedLevel +1);
					GameControl.control.isHoleOver = false;
				}
			}

			if(GUI.Button (new Rect (400, 300, 160, 40), "Start Screen"))
			{
				Application.LoadLevel("StartScreen");
				GameControl.control.isHoleOver = false;
			}
		}
	}

}
