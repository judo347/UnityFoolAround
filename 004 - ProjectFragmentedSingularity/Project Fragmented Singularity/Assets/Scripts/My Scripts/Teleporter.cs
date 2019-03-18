using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			//Get the player
			GameObject player = GameObject.Find("Player");
			Player playerScript = player.GetComponent<Player>();

			if(playerScript.teleportSickness <= 0)
			{
				if (this.CompareTag("Portal1"))
				{
					//Vector3 newPos = new Vector3(-1.934f, 2.47f, 16.386f);
					Vector3 newPos = new Vector3(GameObject.FindGameObjectWithTag("Portal2").transform.position.x + 1,
						GameObject.FindGameObjectWithTag("Portal2").transform.position.y,
						GameObject.FindGameObjectWithTag("Portal2").transform.position.z);

					GameObject.FindGameObjectWithTag("Player").transform.position = newPos;

					playerScript.teleportSickness = 5;
				}

				if (this.CompareTag("Portal2"))
				{
					//Vector3 newPos = new Vector3(-1.934f, 2.47f, 16.386f);
					Vector3 newPos = new Vector3(GameObject.FindGameObjectWithTag("Portal1").transform.position.x + 1,
						GameObject.FindGameObjectWithTag("Portal1").transform.position.y,
						GameObject.FindGameObjectWithTag("Portal1").transform.position.z);

					GameObject.FindGameObjectWithTag("Player").transform.position = newPos;

					playerScript.teleportSickness = 5;
				}
			}
		}
	}
}
