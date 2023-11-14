using UnityEngine;

namespace Gameplay
{
    public class RotacaoJogado : MonoBehaviour
    {
        public UnityEngine.Camera mainCamera;
        private Vector3 _mousePos;
    
        public void Update()
        {
            _mousePos = Input.mousePosition;
            Vector3 mouseConvertedPos = mainCamera.ScreenToWorldPoint(new Vector3(_mousePos.x, _mousePos.y, mainCamera.transform.position.y));
        
            Vector3 lookDirection = mouseConvertedPos - transform.position;
            lookDirection.y = 0f; 

            if (lookDirection != Vector3.zero)
            {
                Quaternion rotation = Quaternion.LookRotation(lookDirection);
                transform.rotation = rotation;
            }

        }
    }
}
