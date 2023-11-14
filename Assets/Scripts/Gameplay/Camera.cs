using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
public class Camera : MonoBehaviour
{

    public GameObject jogado;

    private Transform _transform;
    private Transform _jogadoTransform;
    void Start()
    {
        _transform = GetComponent<Transform>();
        _jogadoTransform = jogado.GetComponent<Transform>();
    }
    
    void Update()
    {
        Vector3 position = _jogadoTransform.position;
        _transform.position =
            new Vector3(position.x, _transform.position.y, position.z);
    }
}
    
}
