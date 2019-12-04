using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject prefab;
    public float SpawnTime = 1f;

    private void Start()
    {
        StartCoroutine(Spawning());
    }

    IEnumerator Spawning()
    {
        while (true)
        {
            Vector3 offset = new Vector3(Random.Range(-10, 10), 0.4f, Random.Range(-10, 10));
            Vector3 SpawnPos = transform.position + offset;
            Instantiate(prefab, SpawnPos, prefab.transform.rotation);
            yield return new WaitForSeconds(SpawnTime);
        }
    }
}
