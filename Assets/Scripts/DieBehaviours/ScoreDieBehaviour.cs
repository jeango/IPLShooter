using UnityEngine;
using System.Collections;

public class ScoreDieBehaviour : AbstractDieBehaviour {

	public int score;

	#region implemented abstract members of AbstractDieBehaviour
	public override void Die (GameObject deadObject)
	{
		ScoreManager.GetInstance ().AddScore (score);
	}
	#endregion
}
