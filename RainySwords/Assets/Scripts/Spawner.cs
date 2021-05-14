using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject sword;

    private float min_X = -2.7f;
    private float max_X = 2.7f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(Random.Range(0.5f, 1.5f));

        GameObject s = Instantiate(sword);

        float x = Random.Range(min_X, max_X);

        s.transform.position = new Vector2(x, transform.position.y);

        StartCoroutine(StartSpawning());
    }
}
