using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene2 : MonoBehaviour {
    float timer = 0;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        timer += Time.deltaTime;

        if (timer >= 3f) SceneManager.LoadScene("Main3");
    }
}
