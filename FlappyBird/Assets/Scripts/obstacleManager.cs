using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class obstacleManager : MonoBehaviour
{
    scoreManager scoreManager_;

    public GameObject obstacle_;
    float Cooldown;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager_ = FindObjectOfType<scoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        obstacleCooldown();
    }

    void obstacleCooldown() {
        if (Cooldown <= 0f)
        {
            obstacleSpawn();

            Cooldown = (3f - (scoreManager_.score_ / 10f));
        }
        else
        {
            Cooldown -= Time.deltaTime;
        }
    }

    void obstacleSpawn()
    {
        Instantiate(obstacle_, new Vector3(5f, Random.Range(-3f, 3f), 0f), Quaternion.identity);
    }
}
