using UnityEngine;
using System.Collections;

public class CollisionDamage : MonoBehaviour {

	public int damage;

	void OnTriggerEnter2D(Collider2D col) {
		HealthManager healthMan = col.gameObject.GetComponentInParent<HealthManager> ();
		if (healthMan) {
			healthMan.TakeDamage (damage);
		}
	}

}
