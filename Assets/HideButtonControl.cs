using UnityEngine;
using System.Collections;

public class HideButtonControl : MonoBehaviour {

	void HidePanelTry1(string panelname) {
		GameObject panel = GameObject.Find (panelname);
		if (panel == null) {
			return;
		}
		RectTransform rect = panel.GetComponent (typeof(RectTransform)) as RectTransform;
		Vector2 scale = rect.localScale;
		scale.x = 0.0f;
		scale.y = 0.0f;
		rect.localScale = scale;
	}

	public void HideButtonClick() {
		Debug.Log ("hide button click");
		HidePanelTry1 ("sinePanel");
		HidePanelTry1 ("cosinePanel");
	}
}
