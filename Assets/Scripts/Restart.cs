using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
    public bool restartMenu;
    public bool restartTutorial;
    public bool restart1;
    public bool restart2;
    public bool restart3;
    public bool restart4;
    public bool restart5;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (restartMenu == true && Input.GetKeyUp(KeyCode.R)) {
            SceneManager.LoadScene("menu");
        }
        if (restartTutorial == true && Input.GetKeyUp(KeyCode.R)) {
            SceneManager.LoadScene("tutorial");
        }
        if (restart1 == true && Input.GetKeyUp(KeyCode.R)) {
            SceneManager.LoadScene("main");
        }
        if (restart2 == true && Input.GetKeyUp(KeyCode.R)) {
            SceneManager.LoadScene("main2");
        }
        if (restart3 == true && Input.GetKeyUp(KeyCode.R)) {
            SceneManager.LoadScene("main3");
        }
        if (restart4 == true && Input.GetKeyUp(KeyCode.R)) {
            SceneManager.LoadScene("main4");
        }
        if (restart5 == true && Input.GetKeyUp(KeyCode.R)) {
            SceneManager.LoadScene("main5");
        }
    }
}
