using UnityEngine;
using System.Collections;

public class EventsManager : MonoBehaviour {

	public delegate void DieAction();

	public event DieAction OnDie;

	public void Die(){
		if(OnDie != null) {
			OnDie ();
		}
	}

}
