using UnityEngine;

pulic class changeColor : MonoBehaviour {
	void Update(){
		if (Input.GetKeyDown(KeyCode.R))
			GetComponent<Renderer>().material.color = color.red;
	}
}