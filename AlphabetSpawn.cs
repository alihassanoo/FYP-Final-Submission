using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphabetSpawn : MonoBehaviour
{
    public GameObject[] letterPrefabs;
    private GameObject go;
    private float RoadLength = 26.7f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnRandomLetter", 2.0f,2.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void spawnRandomLetter()
    {
        int index = 0;
        index = Random.Range(0,25);
        go = Instantiate(letterPrefabs[index]) as GameObject;
        go.SetActive(true);
        go.transform.position = transform.position;
        transform.position += new Vector3(0,0,30);
        int index1 = Random.Range(-7, 7);
        transform.position = new Vector3(index1, transform.position.y, transform.position.z);


    }
}

