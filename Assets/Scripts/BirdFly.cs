using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BirdFly : MonoBehaviour
{
    public float Velocity = 1f;

    [SerializeField] private Rigidbody2D _rigidbody;

    void Start()
    {
        if (_rigidbody == null)
        {
            Debug.LogError("Bird Rigidbody is not assigned");
            gameObject.SetActive(false);
        }
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //jump
            _rigidbody.velocity = Vector2.up * Velocity;
        }
    }
}
