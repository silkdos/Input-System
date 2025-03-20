using UnityEngine;

public class Practice : MonoBehaviour
{
    //Attributes
    public float movementSpeed = 5;
    public float RotationSpeed = 5;
    public Transform cameraTransform;
    //Update is called once per frame

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Player movement by keys
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed);
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);

        //Camera Rotation
        //cameraTransform.RotateAround(transform.position, Vector3.up, Input.GetAxis("Mouse X") * Time.deltaTime * RotationSpeed);

        //Player Rotation
        transform.Rotate(Vector3.right * Input.GetAxis("Mouse X") * Time.deltaTime * RotationSpeed);

        //Zoom camara
        cameraTransform.Translate(cameraTransform.forward * Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime);
    }
}
