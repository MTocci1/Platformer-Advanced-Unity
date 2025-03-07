using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        transform.Translate(new Vector2(input.x, input.y) * speed * Time.deltaTime);
    }
}
