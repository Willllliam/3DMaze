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
		titleObj,
		stageSelectObj,
		gameObj,
		resultObj;

	public TitleViewController titleView;
	public StageSelectViewController stageSelectView;
	public GameViewController gameView;
	public ResultViewController resultView;


	public void ChangeView (Const.ViewType viewType) {
		currentView = viewType;
	}

	public void LateUpdate () {
		switch (currentView) {
			case Const.ViewType.Title:
				Move (titleObj, showPoint);
				Move (stageSelectObj, hidePoint);
				Move (gameObj, hidePoint);
				Move (resultObj, hidePoint);
				break;
			case Const.ViewType.StageSelect:
				Move (titleObj, hidePoint);
				Move (stageSelectObj, showPoint);
				Move (gameObj, hidePoint);
				Move (resultObj, hidePoint);
				break;
			case Const.ViewType.Game:
				Move (titleObj, hidePoint);
				Move (stageSelectObj, hidePoint);
				Move (gameObj, showPoint);
				Move (resultObj, hidePoint);
				break;
			case Const.ViewType.Result:
				Move (titleObj, hidePoint);
				Move (stageSelectObj, hidePoint);
				Move (gameObj, hidePoint);
				Move (resultObj, showPoint);
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