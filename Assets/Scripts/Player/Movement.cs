using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 100f;
    
    public Vector2 Input { get; set; } = Vector2.zero;
    
    private Rigidbody2D rb = null;
    private bool isChangingGravity = false;
    private Vector2 gravity = 10f * Vector2.down;
    private Vector2 movement = Vector2.zero;
    
    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (!isChangingGravity)
        {
            movement = Time.deltaTime * 
                               (gravity + 
                                movementSpeed * Input.x * transform.right.ToVector2());
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = movement;
    }

    public void DetermineGravityDirection()
    {
        isChangingGravity = true;
        rb.velocity = Vector2.zero;
    }

    public void SwitchGravityDirection()
    {
        isChangingGravity = false;
        gravity = Input;
    }
}