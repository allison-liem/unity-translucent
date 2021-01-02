using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public float speed = 2.0f;
    public float moveThreshold = 0.2f;
    private float moveX;

    private Animator animator;
    private Rigidbody2D rigidbody2d;

    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2d = GetComponent<Rigidbody2D>();
        moveX = 0;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        if (Mathf.Abs(horizontal) < moveThreshold)
        {
            animator.SetBool("Walking", false);
            moveX = 0;
        } else
        {
            animator.SetBool("Walking", true);
            animator.SetFloat("MoveX", horizontal);
            moveX = horizontal;
        }
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x += speed * moveX * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }
}
