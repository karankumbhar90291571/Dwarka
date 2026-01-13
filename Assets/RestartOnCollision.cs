using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // Required for TextMeshPro

public class RestartOnCollision : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI messageText;  // Assign your TMP Text UI
    [SerializeField] private float restartDelay = 2f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Obstacle hit! Restarting...");

            if (messageText != null)
            {
                messageText.text = "Game Over! Restarting...";
            }

            Invoke("RestartScene", restartDelay);
        }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
