using UnityEngine;
using System.Collections;

public class CoroutineLesson : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine ("MoveSphere");
	}

	IEnumerator MoveSphere() {
		for(int f = 10; f>= 0; f--) {
			gameObject.transform.position = new Vector3 (f * 0.1f, 1, 1);
			yield return new WaitForSeconds (0.5f);
			print (Time.time);
		}
	}
}