using UnityEngine;
using System.Collections;

public class PipeSpawner : MonoBehaviour {

    public float maxYpos;
    public float SpawnTime;
    public GameObject pipe;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void StartSpawningPipes() {
        InvokeRepeating("SpawnPipe", 0.2f, SpawnTime);
    }

    public void StopSpawningPipes()
    {
        CancelInvoke("SpawnPipe");
    }

    void SpawnPipe() {
        Instantiate(pipe, new Vector3(transform.position.x, Random.RandomRange(-maxYpos, maxYpos), 0), Quaternion.identity);
    }
}
