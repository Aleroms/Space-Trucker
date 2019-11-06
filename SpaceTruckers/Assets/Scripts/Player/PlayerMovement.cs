using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    [SerializeField] float baseSpeed;
    [SerializeField] bool inLevelSelector = false;

    //Needed to keep the player within camera boundaries.
    Vector2 playerSize;
    Vector2 camExtents;
    float minX;
    float maxX;
    float minY;
    float maxY;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        camExtents = new Vector2(Camera.main.orthographicSize * Screen.width / Screen.height, Camera.main.orthographicSize);
        playerSize = GetComponent<SpriteRenderer>().size * transform.localScale;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCameraBoundaryValues();

        Move();
    }

    void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = Vector2.up * Input.GetAxisRaw("Vertical") * speed + (horizontal != 0 ? speed * horizontal + baseSpeed: (!inLevelSelector ? baseSpeed : 0f)) * Vector2.right;
    }


    private void LateUpdate()
    {
        Vector3 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x, minX, maxX);
        playerPos.y = Mathf.Clamp(playerPos.y, minY, maxY);
        transform.position = playerPos;
    }

    private void UpdateCameraBoundaryValues()
    {
        minX = Camera.main.transform.position.x - camExtents.x + playerSize.x / 2;
        maxX = Camera.main.transform.position.x + camExtents.x - playerSize.x / 2;
        minY = Camera.main.transform.position.y - camExtents.y + playerSize.x / 2;
        maxY = Camera.main.transform.position.y + camExtents.y - playerSize.x / 2;
    }

}
