using UnityEngine;
using System.Collections;


[System.Serializable]
public class Boundary
{
    public float minX, maxX;
}
public class PlayerController : MonoBehaviour {

    public float speed;
    public Boundary boundary;
    private Vector2 _newPosition = new Vector2(0.0f, 0.0f);
    public Camera camera;
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this._newPosition = gameObject.GetComponent<Transform>().position; // current position

        Vector2 mousePosition = Input.mousePosition;
        this._newPosition.x = this.camera.ScreenToWorldPoint(mousePosition).x;

        this._BoundaryCheck();

        gameObject.GetComponent<Transform>().position = this._newPosition;
    }
    private void _BoundaryCheck()
    {
        if (this._newPosition.x < this.boundary.minX)
        {
            this._newPosition.x = this.boundary.minX;
        }

        if (this._newPosition.x > this.boundary.maxX)
        {
            this._newPosition.x = this.boundary.maxX;
        }
    }
}
