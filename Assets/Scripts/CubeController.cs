using UnityEngine;
using UnityEngine.InputSystem;

public class CubeController : MonoBehaviour
{
    private CubeBehaviour cubeBehaviour;

    void Start()
    {
        cubeBehaviour = GetComponent<CubeBehaviour>();
    }

    void Update()
    {
        if (Keyboard.current == null)
        {
            return;
        }

        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            cubeBehaviour.RotateClockwise();
        }

        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            cubeBehaviour.RotateCounterClockwise();
        }

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            cubeBehaviour.StopRotation();
        }
    }
}
