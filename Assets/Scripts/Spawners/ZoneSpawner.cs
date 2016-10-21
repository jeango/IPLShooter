using UnityEngine;
using System.Collections;

public class ZoneSpawner : SimpleSpawner {

	public Rect spawnZone;
	public bool showGizmo;
	public Color gizmoColor;

	public float minDistance;
	public LayerMask layerMask;

	public override GameObject Spawn ()
	{
		Vector2 pos = GetRandomPositionInZone ();
		if (pos == Vector2.zero)
			return null;

		GameObject instance = base.Spawn ();
		instance.transform.position = pos;
		return instance;

	}

	Vector2 GetRandomPositionInZone() {

		float randomX, randomY;
		int maxAttempts = 10;

		for (int i = 0; i < maxAttempts; i++) {
			randomX = Random.Range (spawnZone.xMin, spawnZone.xMax);
			randomY = Random.Range (spawnZone.yMin, spawnZone.yMax);
			Vector2 pos = new Vector2 (randomX, randomY);
			if (!Physics2D.OverlapCircle (pos, minDistance, layerMask)) {
				return pos;
			}			
		}

		return Vector2.zero;
	}
	void OnDrawGizmos(){
		if (showGizmo ) {
			GizmoUtils.DrawRectangle (spawnZone, gizmoColor);
		}
	}
}
