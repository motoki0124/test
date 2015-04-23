using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour {

	private void Start () {
		Instantiate(Resources.Load<GameObject>("Prefab/Title"));	
	}
}
