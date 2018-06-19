using System.Collections;
using System.Collections.Generic;
using Vuforia;
using UnityEngine;

public class buttonScript : MonoBehaviour
{

    private GameObject target;
    private GameObject basei;


    void Start() {
        basei = GameObject.FindGameObjectWithTag("Base");
    }


    void Update()

    {

        if (Input.GetMouseButtonDown(0))

        {

            RaycastHit hit;
            GameObject target = null;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //마우스 포인트 근처 좌표를 만든다. 

            if (true == (Physics.Raycast(ray.origin, ray.direction * 10, out hit)))   //마우스 근처에 오브젝트가 있는지 확인
            {
                target = hit.collider.gameObject;
            }



            if (target.Equals(gameObject))  //선택된게 나라면

            {
                if (basei.GetComponent<movement>().mode_on_off == false)
                {
                    basei.GetComponent<movement>().mode_on_off = true;
                    basei.GetComponent<movement>().target_thing = "default";
                }
                else {
                    basei.GetComponent<movement>().mode_on_off = false;
                    basei.GetComponent<movement>().target_thing = gameObject.name;
                }
            }



        }

    }

}

