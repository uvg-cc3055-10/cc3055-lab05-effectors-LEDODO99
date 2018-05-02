using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {
    public float time=0f;
    public float timeToDeactivate=2f;
    public float timeToActivate = 4f;
    public GameObject particles;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (time > timeToDeactivate)
            particles.SetActive(false);
        if (time > timeToActivate)
        {
            particles.SetActive(true);
            time = 0f;
        }

	}
}
