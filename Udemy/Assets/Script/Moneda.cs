using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    private AudioSource audioSource; // Referencia al AudioSource de la moneda

    private void Start()
    {
        // Obtener el componente AudioSource de la moneda
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que colisiona tiene el tag "Player"
        if (other.CompareTag("Player"))
        {
            // Reproduce el sonido de la moneda
            if (audioSource != null && audioSource.clip != null)
            {
                audioSource.Play();
            }
            else
            {
                Debug.LogWarning("AudioSource o AudioClip no asignado en la moneda.");
            }

            // Destruir la moneda después de reproducir el sonido
            Destroy(gameObject, audioSource.clip.length);
        }
    }
}
