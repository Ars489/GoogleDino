using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject deathScreen;

    public void EndGame()
    {
        Obstecle[] obstecles = FindObjectsOfType<Obstecle>();
        for (int i = 0; i < obstecles.Length; i++)
        {
            Destroy(obstecles[i].GetComponent<Rigidbody2D>());
            Destroy(obstecles[i]);
        }
        EnemySpawner enemySpawner = FindObjectOfType<EnemySpawner>();
        Destroy(enemySpawner);
        deathScreen.SetActive(true);
    }
}
