using UnityEngine;
using System.Collections;

[System.Serializable]
public class Speed
{
    public float minSpeed, maxSpeed;

}

public class EnemyController : MonoBehaviour {

    public Speed speed;

    //public Drift drift;

    private float _CurrentSpeed;

    //   private float _CurrectDrift;
    // Use this for initialization
    void Start()
    {
        //call the reset method to move the balloon
        this._Reset();
    }

    // Update is called once per frame
    void Update () {
        Vector2 currentPosition = new Vector2(0.0f, 0.0f);
        currentPosition = gameObject.GetComponent<Transform>().position;

        // currentPosition.y += this._CurrectDrift;
        currentPosition.y -= this._CurrentSpeed;

        gameObject.GetComponent<Transform>().position = currentPosition;
        if (currentPosition.y <= -1.75)
        {
            this._Reset();
        }
    }

    private void _Reset()
    {
        //this._CurrectDrift = Random.Range(drift.minDrift, drift.maxDrift);
        this._CurrentSpeed = Random.Range(speed.minSpeed, speed.maxSpeed);
        Vector2 resetPosition = new Vector2(Random.Range(-1.3f, -0.25f),1.75f);
        gameObject.GetComponent<Transform>().position = resetPosition;
    }
    void OnTriggerEnter2D(Collider2D others)
    {
        if (others.GetComponent<PlayerController>() == null)
            return;
        Destroy(gameObject);
    }
}
