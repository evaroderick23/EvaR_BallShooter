using UnityEngine;

public class UpAndDown : MonoBehaviour
{
    [SerializeField] float distanceToCover;
    [SerializeField] float speed;

    private Vector3 startingPosition;

    void Start()
    {
        startingPosition = transform.position;
    }

    void Update()
    {
        Vector3 v = startingPosition;
        v.y += distanceToCover * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}