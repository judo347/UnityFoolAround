using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public bool[] isFull;
    public string[] slots;

	// Use this for initialization
	void Start () {
		slots = new string[4];
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(slots[0]);
	}

	public void addItem(string item)
	{
		slots[0] = item;
	}
}
