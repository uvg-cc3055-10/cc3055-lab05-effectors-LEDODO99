using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneController : MonoBehaviour {
    public int currentScene=1;
    public bool endedLevel=false;
    public static sceneController instance;
	// Use this for initialization
	void Start () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
        if (endedLevel)
            if (currentScene == 1)
            {
                SceneManager.LoadScene("Dungeon2");
                currentScene = 2;
            }
            else
            {
                SceneManager.LoadScene("Dungeon1");
                currentScene = 1;
            }
                
	}
}
