using UnityEngine;

public class PlayerBorders : MonoBehaviour
{
    public float xMin, xMax;

    void Update()
    {
        // Clamp the player's position within the defined boundaries
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, xMin, xMax),
            transform.position.y,
            transform.position.z
        );
    }
}
