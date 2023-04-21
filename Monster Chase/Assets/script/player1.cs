using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    [SerializeField]
    private float moveForce = 10f;
    [SerializeField]
    private float jumpForce = 11f;

    private float movementX;

    [SerializeField]
    private Rigidbody2D myBody;

    private SpriteRenderer sr;
    private Animator anim;
    private string walknaim = "walk";

    private bool isGrounded;
    private string GROUND = "Ground";

    private string ENEMY ="Enemy";

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();

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
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX, 0f, 0f) * moveForce * Time.deltaTime;
    }

    void AnimatePlayer()
    {
        if (movementX > 0)
        {
            anim.SetBool(walknaim, true);
            sr.flipX = false;
        }
        else if (movementX < 0)
        {
            anim.SetBool(walknaim, true);
            sr.flipX = true;
        }
        else
        {
            anim.SetBool(walknaim, false);
        }
    }
    void playerjump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
            myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GROUND))
        {
            isGrounded = true;
        }

        if(collision.gameObject.CompareTag(ENEMY))
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collison) {
        
        if(collison.CompareTag(ENEMY))
            Destroy(gameObject);
        
    }
}
