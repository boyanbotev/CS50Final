using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] 
    GameObject _catPrefab;
    [SerializeField]
    Transform enemiesParent;

    private void Start()
    { 
        StartCoroutine(SpawnRoutine(2.0f));
    }


    void SpawnEnemy()
    {
        // Spawn Enemy
        Instantiate(_catPrefab, enemiesParent);


        // Start Coroutine to retrigger spawn
        float randomWaitTime = Random.Range(2.0f, 6.9f);
        StartCoroutine(SpawnRoutine(randomWaitTime));
    }

    public IEnumerator SpawnRoutine(float secs)
    {
        yield return new WaitForSeconds(secs);
        SpawnEnemy();
    }

}
