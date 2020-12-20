using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    public GameObject[] roadPrefabs;
    private Transform playerTransform;
    private float spawnZ = 0.0f;
    private float RoadLength = 26.7f;
    private float safeZone = 15.0f;
    private int amntRoadsOnScreen = 5;

    private List<GameObject> activeRoads;
    void Start()
    {
        activeRoads = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        for (int i = 0; i<amntRoadsOnScreen; i++) {
            SpawnRoad();
        }
    }
    void Update() 
    {
        if (playerTransform.position.z - safeZone> (spawnZ - amntRoadsOnScreen * RoadLength)) {
            SpawnRoad();
            DeleteTile();
        }
    }
    void SpawnRoad(int prefabIndex = -1) 
    {
        GameObject go;
        go = Instantiate(roadPrefabs[0]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += RoadLength;
        activeRoads.Add(go);
    }
    void DeleteTile() 
    {
        Destroy(activeRoads[0]);
        activeRoads.RemoveAt(0);

    }
}
