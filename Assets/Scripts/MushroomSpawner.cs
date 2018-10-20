using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSpawner : MonoBehaviour {

    public GameObject mushroomSpawnPoint;
    public Object[] mushroomPrefabs;

    void OnTriggerEnter2D(Collider2D other)
    {
        this.SpawnMushroom();
    }
    void SpawnMushroom()
    {
        int random = Random.Range(0,mushroomPrefabs.Length);
        GameObject mushroom = Object.Instantiate(mushroomPrefabs[(Random.Range(0, mushroomPrefabs.Length))], mushroomSpawnPoint.transform.position, mushroomSpawnPoint.transform.rotation) as GameObject;
        mushroom.GetComponent<Rigidbody2D>().AddForce(new Vector2((Random.Range(-120, 120)), 700));
    }
}
