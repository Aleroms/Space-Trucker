using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    public float speed;

	[SerializeField]
	private float constantRightSpeed;
    [SerializeField] bool inLevelSelector = false;

    //Needed to keep the player within camera boundaries.
    Vector2 playerSize;
    Vector2 camExtents;
    float minX;
    float maxX;
    float minY;
    float maxY;
	[SerializeField, Tooltip("Handles Physics")]
	private Rigidbody2D rBody;

    // Start is called before the first frame update
    void Start()
    {
        camExtents = new Vector2(Camera.main.orthographicSize * Screen.width / Screen.height, Camera.main.orthographicSize);
        playerSize = GetComponent<SpriteRenderer>().size * transform.localScale;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UpdateCameraBoundaryValues();

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

		//Debug.Log($"h:{h} V: {v}");
		
		Vector3 targetVel = new Vector2(h * speed, v * speed) * Time.fixedDeltaTime;

		if (!inLevelSelector)
        {
			targetVel = new Vector2(targetVel.x + constantRightSpeed * Time.fixedDeltaTime, targetVel.y);
			
            //transform.position += Vector3.right * Time.deltaTime * 3;

        }

		rBody.velocity = targetVel;
    }


    private void LateUpdate()
    {
        //Vector3 playerPos = transform.position;
        //playerPos.x = Mathf.Clamp(playerPos.x, minX, maxX);
        //playerPos.y = Mathf.Clamp(playerPos.y, minY, maxY);
        //transform.position = playerPos;
    }

    private void UpdateCameraBoundaryValues()
    {
        minX = Camera.main.transform.position.x - camExtents.x + playerSize.x / 2;
        maxX = Camera.main.transform.position.x + camExtents.x - playerSize.x / 2;
        minY = Camera.main.transform.position.y - camExtents.y + playerSize.x / 2;
        maxY = Camera.main.transform.position.y + camExtents.y - playerSize.x / 2;
    }

}
