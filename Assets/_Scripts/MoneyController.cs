using UnityEngine;
using System.Collections;

public class MoneyController : MonoBehaviour {

    public float speed;
    // Use this for initialization
    void Start()
    {
        this._Reset();
    }

    // Update is called once per frame
    void Update () {
        Vector2 currentPosition = new Vector2(0.0f, 0.0f);
        currentPosition = gameObject.GetComponent<Transform>().position;
        currentPosition.y -= speed;

        // move the gameObject to the currentPosition
        gameObject.GetComponent<Transform>().position = currentPosition;

        // top boundary check - gameObject meets top of camera viewport
        if (currentPosition.y <= -2)
        {
            this._Reset();
        }
    }
    private void _Reset()
    {
        Vector2 resetPosition = new Vector2(Random.Range(-1.3f, 1.3f), 1.75f);
        gameObject.GetComponent<Transform>().position = resetPosition;
    }
    void OnTriggerEnter2D(Collider2D others)
    {
        if (others.GetComponent<PlayerController>() == null)
            return;
        Destroy(gameObject);
    }
}
