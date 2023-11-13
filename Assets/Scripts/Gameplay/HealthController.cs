using UnityEngine;
using UnityEngine.SceneManagement;

namespace Gameplay
{
    public class HealthController: MonoBehaviour
    { 
        public int health;
        
        void Update()
        {
            if (health <= 0)
                if (this.gameObject.CompareTag("Inimigo")) Destroy(gameObject);
                else SceneManager.LoadScene("Perdeu Tudo");
        }
        
        public void TomarDano(int dano)
        {
            health -= dano;
            if (health < 0) health = 0;
            if (gameObject.CompareTag("Player")) GetComponent<AudioSource>().Play();
        }
    }
}