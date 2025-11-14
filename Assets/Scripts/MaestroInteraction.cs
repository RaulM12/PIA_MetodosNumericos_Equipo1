// MaestroInteraction.cs
// Añade este script a tu objeto "Maestro".
// Asegúrate de que tenga un Collider con "Is Trigger" activado.

using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para cambiar de escena

public class MaestroInteraction : MonoBehaviour
{
    // Nombre de la escena del minijuego que debe cargar
    // (Ej: "Minijuego_GaussSeidel")
    public string minigameSceneName;

    // Esta función se llama cuando algo entra en el trigger
    private void OnTriggerEnter(Collider other)
    {
        // Comprobar si lo que entró es el jugador (usando Tags)
        if (other.CompareTag("Player"))
        {
            // 1. Explicar el método (basado en tu documento)
            // Por ahora, usamos un mensaje en la consola.
            // Más adelante, aquí puedes activar una ventana de diálogo.
            Debug.Log("¡Hola, Ingeniero! Vamos a aprender sobre Ecuaciones Lineales.");

            // 2. Entrar al apartado "minijuego"
            // Cargamos la escena del minijuego
            Debug.Log("Iniciando minijuego: " + minigameSceneName);
            
            // Verificamos que el nombre no esté vacío antes de cargar
            if (!string.IsNullOrEmpty(minigameSceneName))
            {
                SceneManager.LoadScene(minigameSceneName);
            }
            else
            {
                Debug.LogWarning("¡No se ha asignado un nombre de escena para el minijuego!");
            }
        }
    }
}