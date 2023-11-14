using System;
using UnityEngine;

namespace Gameplay
{
    public class MovimentoJogado : MonoBehaviour
    {
        private Rigidbody _rigidbody;
    
        void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _rigidbody.freezeRotation = true;
        }
     
        void Update()
        {
            if (Input.GetKey((KeyCode.W))) _rigidbody.AddForce(0, 0, 6);
            if (Input.GetKey((KeyCode.D))) _rigidbody.AddForce(6, 0, 0);
            if (Input.GetKey((KeyCode.S))) _rigidbody.AddForce(0, 0, -6);
            if (Input.GetKey((KeyCode.A))) _rigidbody.AddForce(-6, 0, 0);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Moeda"))
            {
                gameObject.GetComponent<ControleGeral>().AddMoeda();
                Destroy(other.gameObject);
            }
        }
    }
}
