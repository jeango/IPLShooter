using UnityEngine;
using System.Collections;

public class HealthManager : MonoBehaviour {

	public int health;
	private int initHealth;

	public EventsManager eventsManager;

	void Awake() {
		if (!eventsManager) {
			eventsManager = GetComponentInParent<EventsManager> ();
		}
		initHealth = health;
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

	void OnEnable() {
		health = initHealth;
	}

}
