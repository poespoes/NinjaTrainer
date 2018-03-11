using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartManager : MonoBehaviour {
    public bool tutorial;
    public bool main;
    public bool main2;
    public bool main3;
    public bool main4;

    private Player player;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("player").GetComponent<Player>();
    }
	
	// Update is called once per frame
	void Update () {
		if(player.restartStageTimer > 2 && tutorial == true) {
            SceneManager.LoadScene("tutorial");
        }
        if (player.restartStageTimer > 2 && main == true) {
            SceneManager.LoadScene("main");
        }
        if (player.restartStageTimer > 2 && main2 == true) {
            SceneManager.LoadScene("main2");
        }
        if (player.restartStageTimer > 2 && main3 == true) {
            SceneManager.LoadScene("main3");
        }
        if (player.restartStageTimer > 2 && main4 == true) {
            SceneManager.LoadScene("main4");
        }
    }
}
