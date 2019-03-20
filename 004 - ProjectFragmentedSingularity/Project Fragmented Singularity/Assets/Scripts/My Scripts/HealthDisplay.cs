using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Has to be included when working with UI

public class HealthDisplay : MonoBehaviour {

    private int health = 5;
    public Text healthText;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        healthText.text = "HEALTH: " + health;

        if (Input.GetKeyDown(KeyCode.Space))
            health--;

	}
}
