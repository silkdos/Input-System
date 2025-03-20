using UnityEngine;

public class MouseInputs : MonoBehaviour
{
    //Attributes
    public Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Mouse / Touch
        if (Input.GetMouseButtonUp(0))
        {
            print("Boton Izq");
        }
        if (Input.GetMouseButtonUp(1))
        {
            print("Boton Der");
        }
        if (Input.GetMouseButtonUp(2))
        {
            print("Boton Centr");
        }

        //Mouse position
        print("Mouse x: " + Input.mousePosition.x + " / Mouse y: " + Input.mousePosition.y + " / Mouse z: " + Input.mousePosition.z);

        target.position = Input.mousePosition;

    }
}
