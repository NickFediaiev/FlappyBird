using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipes : MonoBehaviour
{
    public float Speed;

    [SerializeField] private Transform _transform;

    void Start()
    {
        if (_transform == null)
        {
            gameObject.SetActive(false);
            Debug.LogError("Pipes transform is not assigned");
        }
    }
    
    void Update()
    {
        _transform.position += Vector3.left * Speed * Time.deltaTime;
    }
}
