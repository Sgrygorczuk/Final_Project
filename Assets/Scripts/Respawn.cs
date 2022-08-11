using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{

    public Transform respawnPoint;
    public string levelName;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Death"))
        {
            SceneManager.LoadScene(levelName);
        }
        else if (collision.CompareTag("Checkpoint"))
        {
            respawnPoint.position = collision.transform.position;
        }
    }
}
