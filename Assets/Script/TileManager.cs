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
    // Start is called before the first frame update
    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        
        for(int i = 0; i < amnTilesOnScreen; i++){
        	SpawnTile();
        	
        }
    }

    // Update is called once per frame
    private void Update()
    {
    	SpawnTile();
        // if(playerTransform.position.z > (spawnZ - (amnTilesOnScreen * tileLength))){
        // 	SpawnTile();
        // }
    }

    private void SpawnTile(int prefabIndex = -1){
    	GameObject go;
    	go = Instantiate(tilePrefabs[0])as GameObject;
    	go.transform.SetParent(transform);
    	go.transform.position = Vector3.forward * spawnZ;
    	spawnZ = spawnZ+tileLength;
    }
}
