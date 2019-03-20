using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float moveSpeed;
    public float turnSpeed;

	public float teleportSickness = 0;

	private Inventory inventory;

	private Camera camera;

	// Use this for initialization
	void Start () {
		//print("yo Im a cylinder");
		camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
		moveSpeed = 8f;
        turnSpeed = 120f;

        XmlParser parser = new XmlParser(); //TODO TEST
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate(1f * Time.deltaTime, 0f, 0f); //Moves the thing //*deltatime is to move at the same speed not depending on pc speed.

		//print(Input.GetAxis("Horizontal")); //1, 0, -1 depending on left or right is pressed.
		//print(Input.GetAxis("Vertical"));

		//Debug.Log(teleportSickness);

		if (teleportSickness > 0)
			teleportSickness -= Time.deltaTime;


		float rotaMovement = Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed;
        float moveMovement = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(0f, 0f, moveMovement);
        transform.Rotate(0f, rotaMovement, 0f);

		camera.transform.position = this.transform.position;
		camera.transform.rotation = this.transform.rotation;

        //transform.Translate(0f, Input.GetAxis("Vertical") * Time.deltaTime, 0f);
        //transform.Translate(0f, 0f, Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed);
    }
}
