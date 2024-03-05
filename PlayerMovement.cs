
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;

    private void awake()
    {
        body = GetCompnonet<Rigidbody2D>();
    }   

    private void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal"), body.velocity.y);
    }
}
