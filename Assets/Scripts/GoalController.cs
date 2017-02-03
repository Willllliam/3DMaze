using UnityEngine;
using System.Collections;

public class GoalController : MonoBehaviour {

	bool isGoal = false;

	private void OnTriggerEnter () {
		if (!isGoal) {
			print ("goal");
			isGoal = true;
			ViewManager.instance.gameView.Goal();
		}
	}

}
