using UnityEngine;

public class CollectibleAnimation : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public float floatHeight = 0.2f;
    public float floatSpeed = 2f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // Rotación
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);

        // Flotación
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;

        transform.position = new Vector3(
            transform.position.x,
            newY,
            transform.position.z
        );
    }
}
