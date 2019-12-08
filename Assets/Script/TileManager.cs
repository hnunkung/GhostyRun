using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
	public GameObject[] tilePrefabs;

	private Transform playerTransform;
	private float spawnZ = 0.0f;
	private float tileLength = 16.0f;
	private int amnTilesOnScreen = 4;
    private List<GameObject> activetiles;
    private float safezone = 20f;
    private int state = 0;

    // Start is called before the first frame update
    private void Start()
    {
        activetiles = new List<GameObject>();
        playerTransform = GameObject.FindWithTag("Player").transform;
        
        for(int i = 0; i < amnTilesOnScreen; i++){
        	SpawnTile();
        }
    }

    // Update is called once per frame
    private void Update()
    {
     //   playerTransform = GameObject.FindObjectWithTag("Player").transform;
     //   print(playerTransform.position);
    	//SpawnTile();
        if (playerTransform.position.z - safezone > (spawnZ - (amnTilesOnScreen * tileLength)))
        {
            SpawnTile();
            print("Position z: "+playerTransform.position.z);
            DeleteTile();
            print("A tile was Deleted");
        }
    }

    private void SpawnTile(int prefabIndex = -1){
    	GameObject go;
    	go = Instantiate(tilePrefabs[0])as GameObject;
    	go.transform.SetParent(transform);
    	go.transform.position = Vector3.forward * spawnZ;
    	spawnZ = spawnZ+tileLength;
        activetiles.Add(go);
    }

    void DeleteTile()
    {

        Destroy(activetiles[0]);
        activetiles.RemoveAt(0);
    }
}
