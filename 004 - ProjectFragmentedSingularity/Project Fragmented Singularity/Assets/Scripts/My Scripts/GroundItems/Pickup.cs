using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** Given to items that can be picked up! */
public class Pickup : MonoBehaviour {

    private Inventory playerInventory;

	// Use this for initialization
	void Start () {
        playerInventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
		//print("TRIGGERED!");
		//Debug.Log(other.name);

		

		if (other.CompareTag("Player"))
		{
			playerInventory.addItem("New Item");

			Destroy(gameObject);
		}


		/*
        if (other.CompareTag("Player"))
        {
            
            for (int i = 0; i < playerInventory.slots.Length; i++)
            {
                if(playerInventory.isFull[i] == false)
                {
                    //ITEM CAN BE PICKED UP!
                    playerInventory.isFull[i] = true;
                    break;
                }
            }
        }*/
	}
}
