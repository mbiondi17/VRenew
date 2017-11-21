using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelNav : MonoBehaviour {

    public string sceneName;
            
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            try
            {
                SceneManager.LoadScene(sceneName);
            }
            catch (Exception ex)
            {
                Debug.Log("Tried to load nonexistent scene: " + sceneName);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            try
            {
                SceneManager.LoadScene(sceneName);
            }
            catch (Exception ex)
            {
                Debug.Log("Tried to load nonexistent scene: " + sceneName);
            }
        }
    }


}
