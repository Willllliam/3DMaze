using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResultViewController : MonoBehaviour {

	[SerializeField]
	private Text
		scoreLabel;

	[SerializeField]
	private Button
		backToTitleButton;

	private void Start()
	{
		backToTitleButton.onClick.AddListener(() => {
			ViewManager.instance.ChangeView(Const.ViewType.Title);
		});
	}

	public void UpdateValue(int id, float score)
	{
		scoreLabel.text = score.ToString("f2") + "s";
		GameManager.instance.ClearStage(id, score);
	}

}
