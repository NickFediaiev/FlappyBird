using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float MaxTime = 1f;
    public float Height = 0f;

    [SerializeField] private GameObject _pipe;

    private float _timer = 0f;

    void Start()
    {
        if (_pipe == null)
        {
            gameObject.SetActive(false);
            Debug.LogError("Pipe GameObject is not assigned");
        }
    }

    void Update()
    {
        if (_timer > MaxTime)
        {
            GameObject newPipe = Instantiate(_pipe);
            newPipe.transform.position = this.transform.position + new Vector3(0, Random.Range(-Height, Height), 0);

            Destroy(newPipe, 15f);
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }
}
