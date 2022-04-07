using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej_02 : MonoBehaviour
{
    public float producto1;
    public float producto2;
    public float producto3;
    public float monto;
    // Start is called before the first frame update
    void Start()
    {
        float totaldelosproductos;
        float dinerofaltante;
        totaldelosproductos = producto1+producto2+producto3;
        dinerofaltante = totaldelosproductos - monto;

        if (totaldelosproductos>monto)
        {
            Debug.Log("El dinero para comprar los productos es insuficiente. Le falta $"+dinerofaltante);
        }
        else if(totaldelosproductos <= monto)
        {
            Debug.Log("El dinero para comprar los productos es suficiente");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
