using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    public float rotationSpeed = 90f;

    private float rotationDirection = 0f;

    void Update()
    {
        transform.Rotate(
            Vector3.up * rotationDirection * rotationSpeed * Time.deltaTime
        );
    }

    public void RotateClockwise()
    {
        rotationDirection = 1f;
    }

    public void RotateCounterClockwise()
    {
        rotationDirection = -1f;
    }

    public void StopRotation()
    {
        rotationDirection = 0f;
    }
}
