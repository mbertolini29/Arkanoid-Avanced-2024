using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    public InputHandler inputHandler;
    [Space]
    public float speedMovement = 10f; 
    public float bounds = 4.5f; //limites

    [Space]
    public UnityEvent OnInteract;
    public UnityEvent OnConsumeItem;

    private void Update()
    {
        // Movement
        ActionMovement();

        // Interaction
        ActionInteraction();

        // Consume Item
        ActionConsumeItem();
    }

    private void ActionMovement()
    {
        float moveInput = inputHandler.GetAxisHorizontal();

        float xMoveInput = moveInput * speedMovement * Time.deltaTime;

        Vector2 playerPosition = transform.position;
        playerPosition.x = Mathf.Clamp(playerPosition.x + xMoveInput, -bounds, bounds);
        transform.position = playerPosition;
    }

    private void ActionInteraction()
    {
        //interactuar con algo, como una puerta
        if (Input.GetKeyDown(KeyCode.E))
        {
            OnInteract?.Invoke();
        }
    }

    private void ActionConsumeItem()
    {
        //consumir algo , como un item
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnConsumeItem?.Invoke();
        }
    }

}
