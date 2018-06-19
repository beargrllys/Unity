using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    private GameObject Sun;//태양
    private GameObject Pluto;//수성
    private GameObject Venus;//금성
    private GameObject Earth;//지구
    private GameObject Moon;//달
    private GameObject Mars;//화성
    private GameObject Jupitor;//목성
    private GameObject Saturn;//토성
    private GameObject Uranus;//천왕성
    private GameObject Neptunus;//해왕성
    private GameObject SunL;//태양
    private GameObject PlutoL;//수성
    private GameObject VenusL;//금성
    private GameObject EarthL;//지구
    private GameObject MoonL;//달
    private GameObject MarsL;//화성
    private GameObject JupitorL;//목성
    private GameObject SaturnL;//토성
    private GameObject UranusL;//천왕성
    private GameObject NeptunusL;//해왕성
    float rotation_speed = 30f*1f, revolve_speed = 30f;
    float smooth = 3.0f;
    public bool mode_on_off = true;
    public string target_thing = "default";
    Quaternion target;
    float Pluto_revolve, Venus_revolve, Earth_revolve, Mars_revolve, Jupitor_revolve, Saturn_revolve, Uranus_revolve, Neptunus_revolve, Moon_revolve;
    float Pluto_rotation, Venus_rotation, Earth_rotation, Mars_rotation, Jupitor_rotation, Saturn_rotation, Uranus_rotation, Neptunus_rotation, Moon_rotation, Sun_rotation;
    Vector3 SunPosition;
    Vector3 EarthPosition;
    // Use this for initialization
    void Start () {
        Sun = GameObject.Find("Sun");
        SunPosition = Sun.transform.position;
        Pluto = GameObject.Find("Pluto");
        Venus = GameObject.Find("Venus");
        Earth = GameObject.Find("realearth");
        EarthPosition = Earth.transform.position;
        Moon = GameObject.Find("Moon");
        Mars = GameObject.Find("Mars");
        Jupitor = GameObject.Find("Jupitor");
        Saturn = GameObject.Find("Saturn");
        Uranus = GameObject.Find("Uranus");
        Neptunus = GameObject.Find("Neptunus");

        SunL = GameObject.Find("SunL");
        PlutoL = GameObject.Find("PlutoL");
        VenusL = GameObject.Find("VenusL");
        EarthL = GameObject.Find("realearth");
        MoonL = GameObject.Find("MoonL");
        MarsL = GameObject.Find("MarsL");
        JupitorL = GameObject.Find("JupitorL");
        SaturnL = GameObject.Find("SaturnL");
        UranusL = GameObject.Find("UranusL");
        NeptunusL = GameObject.Find("NeptunusL");
        Pluto_revolve = revolve_speed * (365f / 88f);
        Venus_revolve= revolve_speed * (365f / 255f);
        Earth_revolve = revolve_speed * (365f / 365f);
        Mars_revolve = revolve_speed * (365f / 687f);
        Jupitor_revolve = revolve_speed * (365f / (365f * 12f) );
        Saturn_revolve = revolve_speed * (365f / (365f * 29f));
        Uranus_revolve = revolve_speed * (365f / (365f * 84f));
        Neptunus_revolve = revolve_speed * (365f / (365f * 100f));
        Moon_revolve = revolve_speed * (365f / 27.3f);

        Sun_rotation = rotation_speed * (1f / 30f);
        Pluto_rotation = rotation_speed * (0.16f);
        Venus_rotation = rotation_speed * (0.68f);
        Earth_rotation = rotation_speed * (1);
        Mars_rotation = rotation_speed * (1.026f);
        Jupitor_rotation = rotation_speed * (0.410f);
        Saturn_rotation = rotation_speed * (0.426f);
        Uranus_rotation = rotation_speed * (0.718f);
        Neptunus_rotation = rotation_speed * (0.669f);
        Moon_rotation = rotation_speed * (1);
    }

    // Update is called once per frame
    void Update () {
        //if (mode_on_off)
        //{
            Earth.transform.RotateAround(SunPosition, Vector3.down, Earth_revolve * Time.deltaTime);
            EarthPosition = Earth.transform.position;
            Moon.transform.RotateAround(EarthPosition, Vector3.down, Moon_revolve * Time.deltaTime);
            Mars.transform.RotateAround(SunPosition, Vector3.down, Mars_revolve * Time.deltaTime);
            Pluto.transform.RotateAround(SunPosition, Vector3.down, Pluto_revolve * Time.deltaTime);
            Venus.transform.RotateAround(SunPosition, Vector3.down, Venus_revolve * Time.deltaTime);
            Jupitor.transform.RotateAround(SunPosition, Vector3.down, Jupitor_revolve * Time.deltaTime);
            Saturn.transform.RotateAround(SunPosition, Vector3.down, Saturn_revolve * Time.deltaTime);
            Uranus.transform.RotateAround(SunPosition, Vector3.down, Uranus_revolve * Time.deltaTime);
            Neptunus.transform.RotateAround(SunPosition, Vector3.down, Neptunus_revolve * Time.deltaTime);

            SunL.transform.Rotate(0.0f, -(Sun_rotation + Time.deltaTime), 0.0f, Space.Self);
            PlutoL.transform.Rotate(0.0f, -(Pluto_rotation + Time.deltaTime), 0.0f, Space.Self);
            VenusL.transform.Rotate(0.0f, -(Venus_rotation + Time.deltaTime), 0.0f, Space.Self);
            EarthL.transform.Rotate(0.0f, -(Earth_rotation + Time.deltaTime), 0.0f, Space.Self);
            MarsL.transform.Rotate(0.0f, -(Mars_rotation + Time.deltaTime), 0.0f, Space.Self);
            JupitorL.transform.Rotate(0.0f, -(Jupitor_rotation + Time.deltaTime), 0.0f, Space.Self);
            SaturnL.transform.Rotate(0.0f, -(Saturn_rotation + Time.deltaTime), 0.0f, Space.Self);
            UranusL.transform.Rotate(0.0f, -(Uranus_rotation + Time.deltaTime), 0.0f, Space.Self);
            NeptunusL.transform.Rotate(0.0f, -(Neptunus_rotation + Time.deltaTime), 0.0f, Space.Self);
            MoonL.transform.Rotate(0.0f, -(Moon_rotation + Time.deltaTime), 0.0f, Space.Self);
       // }


    }
}
