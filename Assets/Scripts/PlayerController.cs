using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D _rb;
    [SerializeField] private float MovementSpeed = 2;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(inputX * MovementSpeed * Time.deltaTime, _rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.gravityScale *= -1;
        }

    }

}
