using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreCounter : MonoBehaviour
{
    scoreManager scoreManager_;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager_ = FindObjectOfType<scoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreManager_.score_++;
    }
}
