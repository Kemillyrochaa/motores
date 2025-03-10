using UnityEngine;

public class ReviveSystem2D : MonoBehaviour
{
    private Vector2 lastCheckpoint; // Última posição salva

    void Start()
    {
        lastCheckpoint = transform.position; // Salva a posição inicial
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Checkpoint"))
        {
            lastCheckpoint = other.transform.position; // Salva novo checkpoint
        }
        else if (other.CompareTag("Revive"))
        {
            Revive();
        }
    }

    void Revive()
    {
        transform.position = lastCheckpoint; // Retorna ao checkpoint salvo
    }
}
