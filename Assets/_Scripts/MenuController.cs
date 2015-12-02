using UnityEngine;
using System.Collections;

public class menucontroller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnStratButton(int sceneToChange) {
        Application.LoadLevel(sceneToChange);  
    }
    public void OnPlayGameButton(int sceneToChange)
    {
        Application.LoadLevel(sceneToChange);
    }
    public void OnBackButton(int sceneToChange)
    {
        Application.LoadLevel(sceneToChange);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
