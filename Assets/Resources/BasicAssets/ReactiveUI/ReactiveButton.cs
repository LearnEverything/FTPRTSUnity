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
		destroyMe.SetActive(false);
		Terrain addedTerr = Terrain.Instantiate(terr, new Vector3(0, 0, 0), Quaternion.identity) as Terrain;
		Vector3 fpsSpawn = addedTerr.GetComponent<GameMap>().getRandomSpawnPoint();
		GameObject fps = Instantiate (
			Resources.Load(fpsLoc, typeof(GameObject)),
			fpsSpawn,
			Quaternion.identity
		) as GameObject;
	}
}
