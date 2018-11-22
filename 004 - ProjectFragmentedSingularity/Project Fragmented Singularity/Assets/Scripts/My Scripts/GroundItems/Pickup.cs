using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/** Given to items that can be picked up! */
public class Pickup : MonoBehaviour {

    private Inventory playerInventory;

	// Use this for initialization
	void Start () {
        //playerInventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        print("TRIGGERED!");
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
