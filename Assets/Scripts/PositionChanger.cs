using UnityEngine;

public class PositionChanger : MonoBehaviour
{
       // Separate float values for ranges
    public float minX = -5f;
    public float maxX = 5f;
    public float minY = -5f;
    public float maxY = 5f;

    private Transform spriteTransform;

    void Start()
    {
        spriteTransform = GetComponent<Transform>();
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            MoveToRandomPosition();
        }
    }

    void MoveToRandomPosition()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        // Position still needs a Vector3 to be applied
        spriteTransform.position = new Vector3(randomX, randomY, spriteTransform.position.z);
    }
}