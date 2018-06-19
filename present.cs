using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class present : MonoBehaviour {

    float rotation_speed = 30f;
    public GameObject[] ArTarget;
    // Use this for initialization
    float Pluto_rotation, Venus_rotation, Earth_rotation, Mars_rotation, Jupitor_rotation, Saturn_rotation, Uranus_rotation, Neptunus_rotation, Moon_rotation, Sun_rotation;

    void Start () {
        ArTarget = GameObject.FindGameObjectsWithTag("Ar_target");
        Pluto_rotation = rotation_speed * (1f / 30f);
        Venus_rotation = rotation_speed * (0.16f);
        Earth_rotation = rotation_speed * (0.68f);
        Mars_rotation = rotation_speed * (1);
        Jupitor_rotation = rotation_speed * (1.026f);
        Saturn_rotation = rotation_speed * (0.410f);
        Uranus_rotation = rotation_speed * (0.426f);
        Neptunus_rotation = rotation_speed * (0.718f);
        Moon_rotation = rotation_speed * (0.669f);
        Sun_rotation = rotation_speed * (1);
    }

    void OnMouseOver() {
        if (Input.GetMouseButtonUp(0)) {
            
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
