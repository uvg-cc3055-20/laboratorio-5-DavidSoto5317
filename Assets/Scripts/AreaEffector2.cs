using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//David Uriel Soto Alvarez 
//17551

public class AreaEffector2 : MonoBehaviour {
    public float time;
    public GameObject child; //Declara un Objeto 
    bool active = true; //Variable que nos ayudara a activar y desactivar los objetos

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        time = time + Time.deltaTime; //Ayudara a medir el tiempo
        if (time >= 3f)
        {
            active = !active; //Cambiara el estado de la variable
            child.SetActive(active); //Activa o desactiva el objeto
            time = 0; //Reinicia el tiempo
        }
    }
}
