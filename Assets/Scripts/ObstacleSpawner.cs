using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float RangeValue1;
    public float RangeValue2;

    public float x;
    public float y;
    public float z;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(ObstacleWave());
    }
    private void spawnEnemy()
    {
      Instantiate(prefab, new Vector3(x, y, z), transform.rotation);
    }
    IEnumerator ObstacleWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(RangeValue1, RangeValue2));
            spawnEnemy();
        }
    }
}
