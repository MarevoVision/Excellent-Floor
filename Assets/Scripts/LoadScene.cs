using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour {

    public string nameScene;

	// Use this for initialization
	void Start () {
        StartCoroutine(Load());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Load()
    {
        yield return new WaitForSeconds(2.0f);
        LoadScenes();
    }

    public void LoadScenes()
    {
        SceneManager.LoadScene(nameScene);
    }
}
