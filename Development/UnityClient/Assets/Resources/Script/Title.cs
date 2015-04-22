using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {
void Update () {
		if (Input.GetMouseButtonUp (0)) {
			Destroy(gameObject);
			GameObject obj = (GameObject)Instantiate(Resources.Load("Prefab/Menu"));	
		}
	}
}

