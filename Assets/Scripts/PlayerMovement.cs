// PlayerMovement.cs
// Añade este script al objeto de tu Jugador (Oso).
// Asegúrate de que el objeto Jugador tenga un componente "CharacterController".

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    public float playerSpeed = 5.0f; // Puedes ajustar la velocidad

    void Start()
    {
        // Obtiene el componente CharacterController que está en este mismo objeto
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Update() se llama una vez por cada fotograma

        // Obtener input del teclado (WASD o flechas)
        float horizontal = Input.GetAxis("Horizontal"); // A/D o Izquierda/Derecha
        float vertical = Input.GetAxis("Vertical");     // W/S o Arriba/Abajo
        
        // Creamos un vector de dirección basado en la orientación del jugador
        Vector3 move = transform.right * horizontal + transform.forward * vertical;
        
        // Mover el jugador usando el CharacterController
        // Time.deltaTime lo hace independiente de los fotogramas (velocidad constante)
        controller.Move(move * playerSpeed * Time.deltaTime);
    }
}