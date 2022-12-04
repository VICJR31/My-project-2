using System.Collections;
using System.Collections.Generic;
//Scene Manager
using UnityEngine.SceneManagement;
using UnityEngine;

public class Intro1 : MonoBehaviour
{
    public float changeTime;
    public string sceneName;

    private void Update() {
        changeTime -= Time.deltaTime;
        if(changeTime <= 0) {
            SceneManager.LoadScene(sceneName);
        }
    }
}
