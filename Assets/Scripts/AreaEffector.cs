using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {
    public float time;
    public GameObject child;
    public GameObject child2;
    bool active = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time = time + Time.deltaTime;
        if(time >= 3f)
        {
            active = !active;
            child.SetActive(active);
            child2.SetActive(active);
            time = 0;
        }
	}
}
