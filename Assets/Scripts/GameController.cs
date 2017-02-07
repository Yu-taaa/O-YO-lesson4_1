using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public GameObject enemy;
	public GameObject stage;
	GameObject[] enemies;
	float stageWidth;
	float stageHeight;

	// Use this for initialization
	void Start () {
		stageWidth = stage.GetComponent<Renderer> ().bounds.size.x;
		stageHeight = stage.GetComponent<Renderer> ().bounds.size.z;
	}

	// Update is called once per frame
	void Update () {
		enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		if (enemies.Length < 5) {
			Instantiate(enemy, new Vector3(Random.Range(-stageWidth/2, stageWidth/2),1,
				Random.Range(-stageHeight/2, stageHeight/2)),Quaternion.identity);
		} 
	}
}