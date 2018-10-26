using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockClic : MonoBehaviour
{
    public GameObject Sphere;
    public AudioClip hitSound;

    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefab;
        public int size;
    }

    public List<Pool> pools;
    public Dictionary<string, Queue<GameObject>> poolDictionary;

    void OnMouseDown()
    {
        Debug.Log("Clock button pressed");
        gameObject.GetComponent<AudioSource>().clip = hitSound;
        gameObject.GetComponent<AudioSource>().Play();


        //Instantiate(Sphere = GameObject.Find("Coin"), transform.position, transform.rotation);

        poolDictionary = new Dictionary<string, Queue<GameObject>>();

        foreach (Pool pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();

            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(true);
                objectPool.Enqueue(obj);
            }

            poolDictionary.Add(pool.tag, objectPool);
        }
    }

    public GameObject SpawnFromPool (string tag, Vector3 position, Quaternion rotation)
    {
        if (!poolDictionary.ContainsKey(tag))
        {
            Debug.LogWarning("Pool with tag " + tag + " doens't exist!");
            return null;
        }

        
        GameObject objectToSpawn = poolDictionary[tag].Dequeue();

        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;

        PooledObject pooledObj = objectToSpawn.GetComponent<PooledObject>();

        if (pooledObj != null)
        {
            pooledObj.OnObjectSpawn();
        }

        poolDictionary[tag].Enqueue(objectToSpawn);

        return objectToSpawn;
    }
}