using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ViewManager 
: SingletonMonoBehaviour<ViewManager> {

	public Const.ViewType currentView;

	[SerializeField]
	private Transform
		showPoint,
		hidePoint,
		homeView,
		stageSelectView,
		gameView,
		resultView;

	public void ChangeView (Const.ViewType viewType) {
		currentView = viewType;
	}

	public void LateUpdate () {
		switch (currentView) {
			case Const.ViewType.Title:
				Move (homeView, showPoint);
				Move (stageSelectView, hidePoint);
				Move (gameView, hidePoint);
				Move (resultView, hidePoint);
				break;
			case Const.ViewType.StageSelect:
				Move (homeView, hidePoint);
				Move (stageSelectView, showPoint);
				Move (gameView, hidePoint);
				Move (resultView, hidePoint);
				break;
			case Const.ViewType.Game:
				Move (homeView, hidePoint);
				Move (stageSelectView, hidePoint);
				Move (gameView, showPoint);
				Move (resultView, hidePoint);
				break;
			case Const.ViewType.Result:
				Move (homeView, hidePoint);
				Move (stageSelectView, hidePoint);
				Move (gameView, hidePoint);
				Move (resultView, showPoint);
				break;
		}
	}

	private float speed = 6f;
	private Vector3 maxVelocity = new Vector3 (0f, 0.01f, 0f);
	private void Move (Transform obj, Transform target) {
		if (obj != null) {
			Vector3 diff = target.position - obj.position;
			Vector3 v = diff * speed * Time.deltaTime;
			if (v.y > 0) {
				if (v.y > maxVelocity.y) v = maxVelocity; 
			} else {
				if (v.y < -maxVelocity.y) v = -maxVelocity; 
			}
			obj.position += v;
		}
	}

}