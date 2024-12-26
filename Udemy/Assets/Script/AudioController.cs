using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
     public static AudioController Instance; // Singleton para acceso global
    private AudioSource audioSource;        // Referencia al AudioSource existente

    private void Awake()
    {
        // Configurar el Singleton
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Mantener entre escenas
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // Obtener el AudioSource ya presente como componente
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("AudioSource no encontrado en el AudioController");
        }
    }

    // Reproduce el sonido del AudioSource
    public void PlaySound()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource es null en PlaySound");
        }
    }
}
