using UnityEngine;

public class CamaraMinimapa : MonoBehaviour
{
    public Transform personaje; // Variable pública para asignar el Transform del personaje desde el Inspector de Unity.
    public bool girarCp;
    void LateUpdate()
    {
        // LateUpdate se llama después de que se hayan actualizado todos los GameObjects en el frame.
        // Esto es útil para la cámara, para asegurar que siga al personaje después de que este se haya movido.

        transform.position = new Vector3(
            personaje.position.x,          // La posición en X de la cámara del minimapa será la misma que la del personaje.
            transform.position.y,          // La posición en Y de la cámara del minimapa se mantiene sin cambios (altura fija).
            personaje.position.z           // La posición en Z de la cámara del minimapa será la misma que la del personaje.
        );
        if (girarCp == true)
        {
            transform.eulerAngles = new Vector3(90,0,personaje.transform.eulerAngles.y);
        }
    }
}
