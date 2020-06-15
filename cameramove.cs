using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    public float mouseSensitivity = 100.0f; //계수 설정
     public float clampAngle = 80.0f;
     public GameObject lights;

     private float rotY = 0.0f; // Y축 방향 기울기
     private float rotX = 0.0f; // X축 방향 기울기

    void Start ()//구동 전 초기값 설정
     {
         Vector3 rot = transform.localRotation.eulerAngles;//초기 상태에 카메라의 기울기 값 저장
         rotY = rot.y;// 현재 Y축 방향 기울기
         rotX = rot.x;// 현재 X축 방향 기울기
         lights = GameObject.Find("Lights");//모든 조명을 묶어둔 "Lights" GameObject를 저장
    }
 
     void Update ()// 프레임마다 변화값 변경
     {
        // 마우스 움직임에 따른 시야 변화 코드
         float mouseX = Input.GetAxis("Mouse X");//마우스 X좌표 이동값
         float mouseY = -Input.GetAxis("Mouse Y");//마우스 Y좌표 이동값

         rotY += mouseX * mouseSensitivity * Time.deltaTime;//변화량만큼 기울기 값에 추가
         rotX += mouseY * mouseSensitivity * Time.deltaTime;
 
         rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);//변화량 조절
 
         Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
         transform.rotation = localRotation;//각도 변경


        //방향키에 따른  위치변화 코드
        float translationX = Input.GetAxis("Horizontal");//좌우 방향키 누를때
        float translationZ = Input.GetAxis("Vertical");//위아래 방향키 누를때
        transform.Translate(translationX * Time.deltaTime * 5, 0, 0);//프레임마다 일정량 만큼 이동
        transform.Translate(0, 0, translationZ * Time.deltaTime * 5);
        this.transform.position = new Vector3(this.transform.position.x, 1.5f, this.transform.position.z);//Y위치는 일정해야함


        //0과 1번튼으로 조명 끄고 켜기
        if (Input.GetKeyDown(KeyCode.Alpha0)) { //0번을 누르면 
            lights.SetActive(false);// 조명 모음 GameObject 비활성화
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))//1번을 누르면 
        {
            lights.SetActive(true);//활성화
        }
    }
}
