using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;

    private float bounds = 4.5f; //limites

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        float xMoveInput = moveInput * moveSpeed * Time.deltaTime;

        Vector2 playerPosition = transform.position;
        playerPosition.x = Mathf.Clamp(playerPosition.x + xMoveInput, -bounds, bounds);
        transform.position = playerPosition;
    }
}
