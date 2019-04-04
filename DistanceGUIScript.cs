using UnityEngine;
using System.Collections;

public class DistanceGUIScript : MonoBehaviour {

    private new GUIText guiText;
    void Start ()
	{

        GameControl.control.totalDistance = 0;
	}

	void Update () 
	{
        GetComponent<GUIText>().text = "Disance: " + (Mathf.Round (GameControl.control.totalDistance)) + " in.";
	}
}
