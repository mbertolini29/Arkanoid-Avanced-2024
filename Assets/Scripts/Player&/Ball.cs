using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour, IInteract
{
    [SerializeField] private Vector2 initialVelocity = new(4f, 6f);
    [SerializeField] private float velocityMultiplier = 1.15f;

    private Rigidbody2D ballRb;
    private bool isBallMoving;

    //
    private IDamage otherCharacter;

    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isBallMoving)
        {
            Launch();
        }
    }

    private void Launch()
    {
        transform.parent = null;
        ballRb.velocity = initialVelocity;
        isBallMoving = true;
    }

    //private void Hit()
    //{
    //    //Destroy(collision.gameObject);

    //    //5% de velocidad más.
    //    ballRb.velocity *= velocityMultiplier;

    //    //Para saber si se destruyeron todos los bloques.
    //    //GameManager.Instance.BlockDestroyed();
    //}

    #region Interface

    public void Interact()
    {
        if(otherCharacter != null)
        {
            //5% de velocidad más.
            ballRb.velocity *= velocityMultiplier;
        }
    }

    #endregion

    private void OnTriggerEnter2D(Collider2D other)
    {
      
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        otherCharacter = other.gameObject.GetComponent<IDamage>();

        //if (otherCharacter != null)
        //{
        //    otherCharacter.Damage(1);
        //}

        VelocityFix();

        //if (collision.gameObject.CompareTag("Block"))
        //{
        //    Hit();
        //    //llamaria al bloque entonces, para destruilo.
        //}

        //VelocityFix();
    }

    //esto corrige un error, por si queda en cero el movimiento
    private void VelocityFix() 
    {
        float velocityDelta = 0.5f;
        float minVelocity = 0.2f;

        if(Mathf.Abs(ballRb.velocity.x) < minVelocity)
        {
            velocityDelta = Random.value < 0.5f ? velocityDelta : -velocityDelta;
            ballRb.velocity += new Vector2(velocityDelta, 0f);
        }

        if(Mathf.Abs(ballRb.velocity.y) < minVelocity)
        {
            velocityDelta = Random.value < 0.5f ? velocityDelta : -velocityDelta;
            ballRb.velocity += new Vector2(0f, velocityDelta);
        }
    }
}
