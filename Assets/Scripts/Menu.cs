using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    //bool screenSwap = false;
    //public SpriteRenderer screen;

    // Use this for initialization
    void Start () {
        //GetComponent<SpriteRenderer>().sortingOrder = 0;
	}
	
	// Update is called once per frame
	void Update () {
        /*if ((Input.GetMouseButtonUp(0)) && screenSwap == true) {
            SceneManager.LoadScene("Main");
        }*/

        if (Input.GetKeyUp(KeyCode.Space)) {
            //screen.sortingOrder = 3;
            SceneManager.LoadScene("tutorial");
            //screenSwap = true;
        }


	}
}
