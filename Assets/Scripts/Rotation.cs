using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationAmount = 90f; // D�nme miktar�

    void Update()
    {
        // Farenin sol d��mesine bas�ld���nda
        if (Input.GetMouseButtonDown(0))
        {
            // Fare t�klamas�n�n konumunu 3D d�nyadaki bir noktaya d�n��t�r
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // E�er bir objeye t�klan�rsa
            if (Physics.Raycast(ray, out hit))
            {
                // T�klanan obje bu script'e ait obje mi diye kontrol et
                if (hit.collider.gameObject == gameObject)
                {
                    // Objeyi belirtilen miktarda d�nd�r
                    transform.Rotate(0,0,rotationAmount);
                }
            }
        }
    }
}
