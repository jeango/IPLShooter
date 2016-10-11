using UnityEngine;
using System.Collections;

public class HealthManager : MonoBehaviour {

	public int health;

	public EventsManager eventsManager;

	void Awake() {
		if (!eventsManager) {
			eventsManager = GetComponentInParent<EventsManager> ();
		}
	}

	public void TakeDamage(int damage) {
		health -= damage;
		if (health <= 0) {
			Die();
		}
	}

	void Die() {
		eventsManager.Die ();
	}

}
