using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;
    public float jumpForce;
    private Rigidbody2D _rigidbody2D;
    private float horizontalinput;
    private bool isJumpPressed;
    private Animator m_animator;


    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumpPressed = true;
        }
        Debug.Log("Horizontal Input: " + horizontalinput);

    }
    private void FixedUpdate()
    {
        float x = horizontalinput * moveSpeed;
        float y = _rigidbody2D.velocity.y;
        _rigidbody2D.velocity = new Vector2(x, y);
        m_animator.SetInteger("AnimState", 1);

        if (isJumpPressed)
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocityX, jumpForce);
            isJumpPressed = false;
        }
    }
}
