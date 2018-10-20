using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomPickUp : MonoBehaviour {

    public int mushroomValue = 1;

    private AudioSource source;
    public AudioClip PickUpClip;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Mario")
        {
            float vol = Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(PickUpClip);

        }
    }


    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Mario")
        {

            Destroy(this.gameObject);
        }
    }
}
