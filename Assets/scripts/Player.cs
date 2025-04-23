using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float velocidad;
    public float senceRot;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            //Hacia adelante
    if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
    {
        transform.Translate(0, 0, velocidad * Time.deltaTime);
    }

    //Hacia la izquierda
    if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
    {
        transform.Translate(-velocidad * Time.deltaTime, 0, 0);
    }

    //Hacia atras
    if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
    {
        transform.Translate(0, 0, -velocidad * Time.deltaTime);
    }

    //hacia la derecha
    if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
    {
        transform.Translate(velocidad * Time.deltaTime, 0, 0);
    }
        transform.Rotate(0, Input.GetAxis("Mouse X") * senceRot * Time.deltaTime, 0);

    }
}
