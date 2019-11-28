using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        rb.velocity = Vector2.right * speed;
        this.transform.position = transform.parent.position;
        this.transform.parent = null;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            Tilemap map = collision.gameObject.GetComponent<Tilemap>();
            map.SetTile(map.WorldToCell(collision.GetContact(0).point), null);
        }
        else if(collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
        this.gameObject.SetActive(false);
    }

    private void OnBecameInvisible()
    {
        this.gameObject.SetActive(false);
    }


}
