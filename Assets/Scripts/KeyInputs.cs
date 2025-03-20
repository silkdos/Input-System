using UnityEngine;

public class KeyInputs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Key Down & Up: Enter
        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Se ha pulsado enter. ");
        }
        if (Input.GetKey(KeyCode.Return))
        {
            print("Se está pulsando enter. ");
        }
        if (Input.GetKeyUp(KeyCode.Return))
        {
            print("Se ha soltado enter. ");
        }

        //Other key
        if (Input.GetKeyDown(KeyCode.A))
        {
            print("Se ha soltado A. ");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("Se ha soltado left. ");
        }
        if (Input.GetKeyDown(KeyCode.F1))
        {
            print("Se ha soltado F1. ");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            print("Se ha soltado Escape. ");
        }
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {

        }
        if (Input.GetKeyUp(KeyCode.RightAlt))
        {
            print("Se ha soltado RightAlt. ");
        }
    }
}
