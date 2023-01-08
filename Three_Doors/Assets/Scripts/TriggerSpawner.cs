using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public Spawner spawner;

    void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.CompareTag("Player"))
      {
        spawner.SpawnObject();
      }
    }
}
