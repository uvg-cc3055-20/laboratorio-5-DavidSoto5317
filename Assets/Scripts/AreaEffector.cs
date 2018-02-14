using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//David Uriel Soto Alvarez 
//17551

public class AreaEffector : MonoBehaviour {
    public float time;
    public GameObject child; //Declara un Objeto 
    public GameObject child2; //Declara otro Objeto
    bool active = true; //Variable que nos ayudara a activar y desactivar los objetos
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time = time + Time.deltaTime; //Ayudara a medir el tiempo
        if(time >= 3f)
        {
            active = !active; //Cambiara el estado de la variable
            child.SetActive(active); //Activa o desactiva el objeto
            child2.SetActive(active); //Activa o desactiva el objeto
            time = 0; //Reinicia el tiempo
        }
	}
}
