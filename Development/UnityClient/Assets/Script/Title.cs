using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {

	public void OnClickTitle() {
		Destroy(gameObject);
		Instantiate(Resources.Load<GameObject>("Prefab/Menu"));	
	}
}

