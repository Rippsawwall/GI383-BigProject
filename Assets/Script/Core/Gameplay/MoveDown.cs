using UnityEngine;

public class MoveDown : MonoBehaviour
{

    public float speed = 10f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed*Time.deltaTime);
    }
}
