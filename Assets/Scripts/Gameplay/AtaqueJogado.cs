using UnityEngine;

public class AtaqueJogado : MonoBehaviour
{
    public GameObject bala;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) Instantiate(bala, transform.position, transform.rotation);
    }
}
