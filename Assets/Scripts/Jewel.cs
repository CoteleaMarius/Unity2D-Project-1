using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jewel : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public Transform spawnJewel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector2.left * (moveSpeed * Time.deltaTime));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector3 position = gameObject.transform.position;
        if (collision.gameObject.CompareTag("Player"))
        {
            position = new Vector3(position.x, position.y - 1f, -100);
            gameObject.transform.position = position;
        }else if (collision.gameObject.CompareTag("Finish"))
        {
            gameObject.transform.position = spawnJewel.position;
        }
    }
}
