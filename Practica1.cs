using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase1 : MonoBehaviour
{
    private float time = 0;

    private bool turnon = false;

    private bool turnoff = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))//CUANDO SE PRESIONA TECLA X
        {
            transform.localScale = transform.localScale * 3;//MULTIPLICANDO EL LOCAL SCALE PARA QUE DE LA ESCALA
            Debug.Log(transform.localScale);//MOSTRAMOS EN CONSOLA LA ESCALA
        }

        if (Input.GetKeyDown((KeyCode.Y)))//cuando se presiona tecla y
        {
            transform.position += new Vector3(1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.O))//Cuando presiona tecla O
        {
            transform.localScale = transform.localScale * 2; 
            transform.position += new Vector3(0, 1, 0);
            Debug.Log(transform.localScale);
        }

        if (Input.GetKeyDown(KeyCode.P))//Cuando presiona tecla P
        {
            transform.localScale = transform.localScale * 1/2; //Multiplica la escala por un medio
            transform.position += new Vector3(0, -1, 0);//Le resta la posicion a Y uno
            Debug.Log(transform.localScale);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
           
           
                turnon = true;
                turnoff = false;
                // transform.localScale = new Vector3(transform.localScale.x+1,transform.localScale.y+1, transform.localScale.z+1) ; 
                //transform.position += new Vector3(0, 1, 0);
                
                //Debug.Log((transform.localScale));
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            turnoff = true;
            turnon = false;
            
        }

        if (turnon==true)
        {
            transform.localScale = new Vector3(transform.localScale.x + (3 * Time.deltaTime), transform.localScale.y + (3 * Time.deltaTime), transform.localScale.z + (3 * Time.deltaTime));
            transform.position += new Vector3(0, 1 * Time.deltaTime, 0);
        }

        if (turnoff==true)
        {
            transform.localScale = new Vector3(transform.localScale.x - (2 * Time.deltaTime), transform.localScale.y - (2 * Time.deltaTime), transform.localScale.z - (2 * Time.deltaTime));
            transform.position += new Vector3(0, -1 * Time.deltaTime, 0);
        }
    }
}
