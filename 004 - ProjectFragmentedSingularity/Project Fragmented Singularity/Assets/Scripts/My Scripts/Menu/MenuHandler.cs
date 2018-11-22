using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour {

    public void ExitButtonAction(){
        Application.Quit();
    }

    public void StartGameAction(){
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("escape"))
            Application.Quit();
	}
}
