using UnityEngine;
using System.Collections;

public class ExplodeDieBehaviour : AbstractDieBehaviour {

	public GameObject explosionPrefab;

	public override void Die (GameObject deadObject)
	{
		Instantiate (explosionPrefab, deadObject.transform.position, Quaternion.identity);
	}



}
