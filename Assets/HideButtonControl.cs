using UnityEngine;
using System.Collections;

public class HideButtonControl : MonoBehaviour {

	void DisplayPanelTry1(string panelname, bool doShow) {
		GameObject panel = GameObject.Find (panelname);
		if (panel == null) {
			return;
		}
		RectTransform rect = panel.GetComponent (typeof(RectTransform)) as RectTransform;
		Vector2 scale = rect.localScale;
		if (doShow) {
			scale.x = 1.0f;
			scale.y = 1.0f;
		} else {
			scale.x = 0.0f;
			scale.y = 0.0f;
		}
		rect.localScale = scale;
	}

	public void HideButtonClick() {
		Debug.Log ("hide button click");
		DisplayPanelTry1 ("sinePanel", /* doShow=*/ false);
		DisplayPanelTry1 ("cosinePanel", /* doShow=*/ false);
	}

	public void ShowButtonClick() {
		Debug.Log ("show button click");
		DisplayPanelTry1 ("sinePanel", /* doShow=*/ true);
		DisplayPanelTry1 ("cosinePanel", /* doShow=*/ true);
	}
}
