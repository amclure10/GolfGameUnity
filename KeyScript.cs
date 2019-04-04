using UnityEngine;
using System.Collections;

public class KeyScript : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other) 
	{
		if (other.tag == "Ball") 
		{
			GameObject[] lockedBlocks = (GameObject.FindGameObjectsWithTag("Locked"));
			for(var i = 0 ; i < lockedBlocks.Length ; i ++)
			{
				Destroy(lockedBlocks[i]);
			}
            GetComponent<AudioSource>().Play ();
			Destroy (gameObject);
		} 

	}

}