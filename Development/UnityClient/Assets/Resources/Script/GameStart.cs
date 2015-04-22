using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour {

void Start () {
		GameObject obj = (GameObject)Instantiate(Resources.Load("Prefab/Title"));	
		obj.transform.parent = transform;
	}
}
