using UnityEngine;
using System.Collections;

public class SimpleSpawner : MonoBehaviour {

	public GameObject prefab;
	public GameObject parentObject;
	public bool useParentObjectLayer;

	[Tooltip("Delay before first spawn")]
	public float spawnDelay;

	public float spawnInterval;

	void OnEnable() {
		StartCoroutine (SpawnCoroutine ());
	}

	void OnDisable() {
		StopAllCoroutines ();
	}

	IEnumerator SpawnCoroutine(){
		yield return new WaitForSeconds (spawnDelay);
		Spawn ();
		do {
			yield return new WaitForSeconds(spawnInterval);
			Spawn();
		} while (true);
	}

	public virtual GameObject Spawn() {
		GameObject instance = (GameObject)Instantiate (prefab);
		instance.transform.position = transform.position;
		instance.layer = gameObject.layer;
		if (parentObject) {
			instance.transform.SetParent (parentObject.transform);
			if (useParentObjectLayer) {
				instance.layer = parentObject.layer;
			}
		}

		return instance;

	}

}
