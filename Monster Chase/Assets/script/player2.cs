using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    [SerializeField]
    private float moveForce2 = 10f;
    [SerializeField]
    private float jumpForce2 = 11f;

    private float movementX2;

    [SerializeField]
    private Rigidbody2D myBody2;

    private SpriteRenderer sr2;
    private Animator anim2;
    private string walknaim2 = "walk2";
    private bool isGrounded;
    private string GROUND = "Ground";

    private void Awake()
    {
        myBody2 = GetComponent<Rigidbody2D>();
        anim2 = GetComponent<Animator>();
        sr2 = GetComponent<SpriteRenderer>();

    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerKeyboard();
        AnimatePlayer();
    }
    private void FixedUpdate()
    {
        playerjump();
    }
    void PlayerKeyboard()
    {
        movementX2 = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX2, 0f, 0f) * moveForce2 * Time.deltaTime;
    }

    void AnimatePlayer()
    {
        if (movementX2 > 0)
        {
            anim2.SetBool(walknaim2, true);
            sr2.flipX = false;
        }
        else if (movementX2 < 0)
        {
            anim2.SetBool(walknaim2, true);
            sr2.flipX = true;
        }
        else
        {
            anim2.SetBool(walknaim2, false);
        }
    }
    void playerjump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
            myBody2.AddForce(new Vector2(0f, jumpForce2), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GROUND))
        {
            isGrounded = true;
        }
    }
}
