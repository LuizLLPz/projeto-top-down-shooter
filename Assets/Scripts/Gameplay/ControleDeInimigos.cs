using System.Collections;
using UnityEngine;

namespace Gameplay
{
    public class ControleDeInimigos : MonoBehaviour
    {
        public GameObject inimigo;

        public float delay;
        void Start()
        {
            StartCoroutine(CriarInimigos());
        }
    

        IEnumerator CriarInimigos()
        {
            Vector3 position = transform.position;
            while (true)
            {
                Instantiate(inimigo, new Vector3(position.x + Random.Range(0, 10), 0, position.x + Random.Range(0, 10)), Quaternion.identity);
                yield return new WaitForSeconds(delay);
            }
        }
    }
}
