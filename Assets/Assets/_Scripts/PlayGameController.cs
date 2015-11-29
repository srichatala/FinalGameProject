using UnityEngine;
using System.Collections;

public class PlayGameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnStartButton()
    {
        Application.LoadLevel("Level1");
    }
}
