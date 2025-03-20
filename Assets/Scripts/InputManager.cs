using UnityEngine;

public class InputManager : MonoBehaviour
{
    //Attributes
    public Transform cubeTransform;
    public float speed = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Input.GetAxis("Horizontal");
        Debug.DrawRay(cubeTransform.position, Vector3.right * Input.GetAxis("Horizontal"), Color.red);
        //Debug.DrawRay(cubeTransform.position, Vector3.right * Input.GetAxis("Horizontal"), Color.red);
        Debug.DrawRay(cubeTransform.position, Vector3.forward * Input.GetAxis("Vertical"), Color.blue);
        //Debug.DrawRay(cubeTransform.position, Vector3.forward * Input.GetAxis("Vertical"), Color.blue);
        print(" Vertical: " + Input.GetAxis("Vertical"));
        if (Input.GetButtonUp("Fire1"))
        {
            print("Fire!! ");
        }

        //Mouse Wheel
        print("Mouse wheel: " + Input.GetAxis("Mouse ScrollWheel"));

        //Movement by Mouse
        cubeTransform.Translate(Vector3.right * Input.GetAxis("Mouse X") * Time.deltaTime * speed);
        cubeTransform.Translate(Vector3.forward * Input.GetAxis("Mouse Y") * Time.deltaTime * speed);

        //Movement by Keys
        cubeTransform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed);
        cubeTransform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * speed);
    }
}
