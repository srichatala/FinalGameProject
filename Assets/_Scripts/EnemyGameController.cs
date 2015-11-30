using UnityEngine;
using System.Collections;

public class EnemyGameController : MonoBehaviour {

    public int enemyCarCount;
    public GameObject enemyCar;
    // Use this for initialization
    void Start () {
        this._GenerateDevil();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private void _GenerateDevil()
    {
        for (int count = 0; count < enemyCarCount; count++)
        {
            Instantiate(enemyCar);
        }
    }
}
