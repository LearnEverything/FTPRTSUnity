using UnityEngine;
using System.Collections;

public class ReactiveButton : MonoBehaviour {
	public Terrain terr;
	// Use this for initialization
	public GameObject destroyMe;
	public string fpsLoc = "BasicAssets/CharacterController/First Person Controller";
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void joinMap(){
		//GetComponent<destroyMe>.enabled = false;
		Terrain.Instantiate(terr, new Vector3(0, 0, 0), Quaternion.identity);
		GameObject fps = Instantiate (
			Resources.Load(fpsLoc, typeof(GameObject)),
			new Vector3(0, 50, 0),
			Quaternion.identity
		) as GameObject;
		//, new Vector3(0, 50, 0), Quaternion.identity
		//Instantiate(BasicMap, new Vector3(0, 0, 0), Quaternion.identity);
		object spawnPoints = terr.GetComponent<GameMap>().spawnPoints;
		Debug.Log (spawnPoints);
	}
}
