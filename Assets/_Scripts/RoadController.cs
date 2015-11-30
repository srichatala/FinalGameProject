using UnityEngine;
using System.Collections;

public class RoadController : MonoBehaviour {


    //Public variables
    public float Speed;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 currentPosition = new Vector2(0.0f, 0.0f);
        currentPosition = gameObject.GetComponent<Transform>().position;
        currentPosition.y -= Speed;

        gameObject.GetComponent<Transform>().position = currentPosition;
        if (currentPosition.y <= -3.5)
        {
            this._Reset();
        }
    }
    private void _Reset()
    {
        Vector2 resetPosition = new Vector2(0.0f, 3.5f);
        gameObject.GetComponent<Transform>().position = resetPosition;
    }
}
