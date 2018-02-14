using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//David Uriel Soto Alvarez 
//17551

public class Weight : MonoBehaviour {
    LineRenderer line; //Crea un objeto de tipo Line Renderer
    DistanceJoint2D distanceJoint; //Crea un objeto de tipo distance joint

	// Use this for initialization
	void Start () {
        distanceJoint = GetComponent<DistanceJoint2D>(); //Obtiene las variables del programa
        line = GetComponent<LineRenderer>(); //Obtiene las variables del objeto

    }

    // Update is called once per frame
    void Update () {
        line.SetPosition(0, transform.position); //Actualiza la posicion de inicio de la linea renderer
        line.SetPosition(1,distanceJoint.connectedBody.transform.position); //Actualiza la posicion del final de la linea renderer
    }
}
