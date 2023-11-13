using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

namespace Gameplay
{
    public class Inimigo: MonoBehaviour
    {
        private Transform _jogado;
        public float velocidade;
        public int dano;
        private Rigidbody _rigidbody;
        
        void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _jogado = GameObject.FindWithTag("Player").transform;
        }
        
        void Update()
        {
            Vector3 direction = _jogado.position - transform.position;
            direction.Normalize();
            _rigidbody.AddForce(direction * velocidade, ForceMode.Force);
        }
        
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                other.gameObject.GetComponent<HealthController>().TomarDano(dano);
            }
        }
    }
}