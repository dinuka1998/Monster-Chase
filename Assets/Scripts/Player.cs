using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float jumpForce = 11f;
    [SerializeField]
    private float moveForce = 10f;
    private float movementX;
    private Rigidbody2D playerBody;
    private Animator playerAnim;
    private string WALK_ANIMATION = "Walk";
    private SpriteRenderer playerSpritRenderer;
    private bool isGrounded;
    private string GROUND_TAG = "Ground";
     private string ENEMY_TAG = "Enemy";
    private void Awake() 
    {

        playerBody = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
        playerSpritRenderer = GetComponent<SpriteRenderer>();    

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        PlayerMoveKeyboard();
        AnimatePlayer();
        PlayerJump();
        
    }

    void PlayerMoveKeyboard() 
    {

        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;

    }

    void AnimatePlayer() 
    {

        //moving player to right side
        if(movementX > 0)
        {

            playerAnim.SetBool(WALK_ANIMATION, true);
            playerSpritRenderer.flipX = false;

        }
        //moving player to left side
        else if(movementX < 0)
        {

             playerAnim.SetBool(WALK_ANIMATION, true);
             playerSpritRenderer.flipX = true;

        }
        else
        {

             playerAnim.SetBool(WALK_ANIMATION, false);

        }

    }

    void PlayerJump() 
    {

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
            playerBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);

        }

    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {

        if(collision.gameObject.CompareTag(GROUND_TAG))
            isGrounded = true;

        if(collision.gameObject.CompareTag(ENEMY_TAG))
            Destroy(gameObject);
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {

        if(collision.CompareTag(GROUND_TAG))
            Destroy(gameObject);


    }
} // class
