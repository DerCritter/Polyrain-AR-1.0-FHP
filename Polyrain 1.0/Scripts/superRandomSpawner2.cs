using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superRandomSpawner2 : MonoBehaviour {

	public GameObject[] spawnees;
	public GameObject[] spawnPoints;

	/// The height all objects need to be spawned at.
	public float spawnPositionY;

	public float radius = 2;
	public float spawnTime = 600f;

	int spawneeIndex;
	int spawnPointIndex;
	Vector3 spawnPosition;

	void Start() {
		InvokeRepeating ("Spawn", 2, 2);

		spawnPoints = GameObject.FindGameObjectsWithTag("spawnPoint");
	}

	// Update is called once per frame
	void Update () {
		SpawnRandom();
	}

	int GetRandom(int count) {
		return Random.Range(0, count);
	}

	Vector3 GetRandomVector (Vector3 vec) {
		Vector3 randomVector = (Random.insideUnitSphere* radius) + vec;
		return new Vector3(randomVector.x, spawnPositionY, randomVector.z);
	}

	void SpawnRandom() {
		spawneeIndex = GetRandom(spawnees.Length);
		spawnPointIndex = GetRandom(spawnPoints.Length);
		spawnPosition = GetRandomVector(spawnPoints[spawnPointIndex].transform.position);
		Instantiate(spawnees[spawneeIndex], spawnPosition, spawnPoints[spawnPointIndex].transform.rotation);
	}
}