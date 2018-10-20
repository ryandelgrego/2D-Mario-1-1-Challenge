using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaController : MonoBehaviour {

    public float speed;
    public float wallHitWidth;
    public float wallHitHeight;

    private bool wallHit;
    public Transform wallcheck;

    public LayerMask allWall;
    public LayerMask isGround;

    private Rigidbody2D rb2d;
    private bool facingRight = true;

    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	
	void FixedUpdate () {
        transform.Translate(speed * Time.deltaTime, 0, 0);

    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        wallHit = Physics2D.OverlapBox(wallcheck.position, new Vector2(wallHitWidth, wallHitHeight), 0, isGround);

        if (wallHit == true)
        {
            speed = speed * -1;
            facingRight = !facingRight;
            Vector2 Scaler = transform.localScale;
            Scaler.x = Scaler.x * -1;
            transform.localScale = Scaler;
        }
    }
}
