using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishController : MonoBehaviour
{
    public Transform spawnGround;
    public Transform spawnObstacle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            collision.gameObject.transform.position = spawnGround.position;
        }else if (collision.collider.CompareTag("Obstacle"))
        {
            collision.gameObject.transform.position = spawnObstacle.position;
        }
    }
}
