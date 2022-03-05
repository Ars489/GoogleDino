using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
   [Header("Bird spawner")]
   public Transform pointSpawnBird;
   public GameObject bird; 
   
   [Header("Tree spawner")]
   public Transform pointSpawnTree;
   public GameObject[] tree;
   
   [Header("Time properties")]
   public float minTime = 0.5f;
   public float maxTime = 3f;
   private void Start()
   {
      StartCoroutine(SpawnDelay());
   }

   private void SpawnTree()
   {
      Instantiate(tree[Random.Range(0,tree.Length)], pointSpawnTree.position, Quaternion.identity);
   }

   private IEnumerator SpawnDelay()
   {
      if (Random.Range(0, 100) >= 30)
      {
        SpawnBird();
      }
      else
      {
         SpawnTree();
      }

      yield return new WaitForSeconds(Random.Range(minTime,maxTime));
      StartCoroutine(SpawnDelay());
   }

   private void SpawnBird()
   {
      Instantiate(bird, pointSpawnBird.position, Quaternion.identity);
   }
}
