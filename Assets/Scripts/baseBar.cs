using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseBar : MonoBehaviour {
    public Color color0;
    public Color color1;
    public Color color2;
    public Color color3;

    private Player player;
    private float caughtTimer;
    //private SpriteRenderer Color;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("player").GetComponent<Player>();
        //player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        //Player playerScript = player.GetComponent<Player>();
    }
	
	// Update is called once per frame
	void Update () {
        if (player.caughtTimer <= 0.29f) {
            //Debug.Log("ALERT 1 !");
            gameObject.GetComponent<SpriteRenderer>().color = color0;
        }
        if (player.caughtTimer >= 0.3f && player.caughtTimer <= 0.6f) {
            //Debug.Log("ALERT 1 !");
            gameObject.GetComponent<SpriteRenderer>().color = color1;
        }
        if (player.caughtTimer >= 0.6f && player.caughtTimer <= 0.8f) {
            //Debug.Log("ALERT 2 !");
            gameObject.GetComponent<SpriteRenderer>().color = color2;
        }
        if (player.caughtTimer >= 0.8f) {
            //Debug.Log("ALERT 3 !");
            gameObject.GetComponent<SpriteRenderer>().color = color3;
        }
        if (player.caughtCheck == true) {
            gameObject.GetComponent<SpriteRenderer>().color = color2;
        }
    }
}
