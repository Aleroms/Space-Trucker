using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private void OnBecameInvisible()
    {
        this.gameObject.SetActive(false);
    }


}
