using UnityEngine;
using System.Collections;

public class GameMap : MonoBehaviour {

	private GameObject[] spawnPoints;

	void Awake() {
		spawnPoints = GameObject.FindGameObjectsWithTag("Respawn");
	}
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Vector3 getRandomSpawnPoint(){
		//Debug.Log (Random.Range(0, spawnPoints.Length));
		Debug.Log (spawnPoints.Length);
		GameObject randomSpawn = spawnPoints[Random.Range(0, spawnPoints.Length)];
		//Debug.Log (randomSpawn.transform.localPosition);
		return randomSpawn.transform.localPosition;
	}
}
