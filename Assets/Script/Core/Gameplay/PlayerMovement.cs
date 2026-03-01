using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 5f;
    public float returnspeed = 2f;
    private Vector3 centerPosition;

    void Start()
    {
        centerPosition = transform.position;
    }

    void Update()
    {
        float move = 0f;

        // ===== PC =====
        if (Input.GetKey(KeyCode.A))
            move = -moveSpeed;
        else if (Input.GetKey(KeyCode.D))
            move = moveSpeed;

        // ===== Mobile =====
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.position.x < Screen.width / 2)
                move = -moveSpeed;
            else
                move = moveSpeed;
        }

        // ===== Movement =====
        if (move != 0)
        {
            transform.position += new Vector3(move * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.position = Vector3.Lerp(
                transform.position,
                centerPosition,
                returnspeed * Time.deltaTime
            );
        }
    }
}
