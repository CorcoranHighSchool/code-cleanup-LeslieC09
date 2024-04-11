using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializedField] private float rotationSpeed;
private const string horizontal = "Horizontal";
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, (horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
