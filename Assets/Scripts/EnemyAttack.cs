using UnityEngine.SceneManagement;
using UnityEngine;

public class EnemyAttack : MonoBehaviour 
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Derrota");
        } else if (collision.gameObject.CompareTag("Bala"))
        {
            CambioEscena.puntos += 1;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
