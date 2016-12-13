using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spawnDelayCoroutine : MonoBehaviour
{
    public GameObject gem;
    public List<GameObject> gems = new List<GameObject>();
    bool finishedSpawning;
    void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }
    private IEnumerator SpawnCoroutine()
    {
        finishedSpawning = false;
        for (int y = 0; y < 2; y++)
        {
            for (int x = 0; x < 2; x++)
            {
                GameObject g = Instantiate(gem, new Vector3(x, y, 0), Quaternion.identity) as GameObject;
                gems.Add(g);
                //Wait for a second before continuing the for-loop
                yield return new WaitForSeconds(1f);
            }
        }
        finishedSpawning = true;
    }
    void Update()
    {
        if (!finishedSpawning)
            return;
        //Make the gems fall
    }
}