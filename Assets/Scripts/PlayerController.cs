using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerController : MonoBehaviour
{
    private int _jeweCount = 0;
    public Text jewelText;
    public float speed = 5.0f;
    public Rigidbody2D playerRb;
    private bool _isJump = false;
    private bool _isGround = false;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isJump = true;
        }
    }
    private void FixedUpdate()
    {
        if (_isJump && _isGround)
        {
            playerRb.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
            _isJump = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _isGround = true;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        _isGround = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        _isGround = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Jewel"))
        {
            _jeweCount++;
            jewelText.text = Convert.ToString(_jeweCount);
        }
    }
}
