using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class obstacleManager : MonoBehaviour
{
    public GameObject obstacle_;
    float Cooldown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        obstacleCooldown();
    }

    void obstacleCooldown() {
        if (Cooldown <= 0 )
        {
            obstacleSpawn();

            Cooldown = 3;
        }
        else
        {
            Cooldown -= Time.deltaTime;
        }
    }

    void obstacleSpawn()
    {
        Instantiate(obstacle_, new Vector3(5, Random.Range(-3, 3), 0), Quaternion.identity);
    }
}
