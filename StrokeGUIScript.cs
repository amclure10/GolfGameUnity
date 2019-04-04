using UnityEngine;
using System.Collections;

public class StrokeGUIScript : MonoBehaviour {

	void Start ()
	{
		GameControl.control.strokes = 0;
	}

	void Update () 
	{
        GetComponent<GUIText>().text = "Stokes: " + GameControl.control.strokes;
	}
}
