using UnityEngine;
using System.Collections;

public class ZoneSpawner : SimpleSpawner {

	public Rect spawnZone;
	public bool showGizmo;
	public Color gizmoColor;

	public override GameObject Spawn ()
	{
		GameObject instance = base.Spawn ();
		instance.transform.position = GetRandomPositionInZone ();
		return instance;


	}

	Vector2 GetRandomPositionInZone() {
		float randomX = Random.Range (spawnZone.xMin, spawnZone.xMax);
		float randomY = Random.Range (spawnZone.yMin, spawnZone.yMax);
		return new Vector2 (randomX, randomY);

	}
	void OnDrawGizmos(){
		if (showGizmo ) {
			GizmoUtils.DrawRectangle (spawnZone, gizmoColor);
		}
	}
}
