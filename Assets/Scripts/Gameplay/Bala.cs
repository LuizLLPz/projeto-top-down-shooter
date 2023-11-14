using UnityEngine;

namespace Gameplay
{
    public class Bala : MonoBehaviour
    {
        public float velocidade = 8f;

        public int dano = 10;
    
        void Update()
        {
            transform.Translate(Vector3.forward * (velocidade * Time.deltaTime));
            Destroy(gameObject, 6f);
        }
        
        void OnCollisionEnter(Collision colisao) {
            if (colisao.gameObject.CompareTag("Inimigo"))
            {
                colisao.gameObject.GetComponent<HealthController>().TomarDano(dano);
                Destroy(gameObject);
            }
        }
    }
}
