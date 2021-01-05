using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BirdFly : MonoBehaviour
{
    public float Velocity = 1f;

    [SerializeField] private Rigidbody2D _rigidbody;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //jump
            _rigidbody.velocity = Vector2.up * Velocity;
        }
    }
}
