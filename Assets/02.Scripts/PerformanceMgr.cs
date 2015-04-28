using UnityEngine;
using System.Collections;

public class PerformanceMgr : MonoBehaviour {

	private LightShadows shadowType = LightShadows.None;

	void Awake() {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			switch (iPhone.generation) {
			case iPhoneGeneration.iPhone4S:
				shadowType = LightShadows.Hard;
				break;
			case iPhoneGeneration.iPhone5:
			case iPhoneGeneration.iPhone5S:
			case iPhoneGeneration.iPhone5C:
				shadowType = LightShadows.Soft;
				break;
			default:
				shadowType = LightShadows.None;
				break;
			}
			GameObject.Find("Directional Light").GetComponent<Light>().shadows = shadowType;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
