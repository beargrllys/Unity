using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamecontroller : MonoBehaviour
{
    //시작 문
    private GameObject player;
    private GameObject start_point1;
    private GameObject start_point2;
    private GameObject start_tile;
    private Collider collider;
    private GameObject stage1_trigger;
    //다리1
    private GameObject start_bridge;
    private GameObject stage1_door;
    private GameObject mine_bot1;
    private GameObject mine_bot2;
    private GameObject mine_bot3;
    private GameObject mine_bot4;
    private GameObject mine_bot5;
    private GameObject mine_bot6;
    private GameObject mine_bot7;
    //다리2
    private GameObject bridge1;
    private GameObject bot1;
    private GameObject bot2;
    private GameObject bot3;
    private GameObject bot4;
    private GameObject bot5;
    private GameObject stage2_door;
    //다리3
    private GameObject bridge2;
    private GameObject final_door;
    private GameObject final_item;
    public float posR_x;
    public float posR_z;
    public float posM_x;
    public float posM_z;
    private Vector3 posR;
    public AudioSource music;

    //다른 필요한 변수 선언
    private int score;
    int[] stage1_HP = new int[7];
    int[] stage2_HP = new int[5];
    bool wait = true, start = false, stage1 = false, stage1_start = false, stage2 = false, stage2_start = false, stage3 = false, final = false;
    float speed = 10.0f; int mine = 0; float time=0; int delay = 3; 
    int fly = 0;
    Vector3 tempvector, tempvector1, tempvector2, tempvector3, tempvector4, tempvector5, tempvector6;

    // Use this for initialization
    void Start () {
        music.Play();
        player = GameObject.Find("Player");
        start_point1 = GameObject.Find("start_point1");
        start_point2 = GameObject.Find("start_point2");
        start_tile = GameObject.Find("start_tile");
        start_bridge = GameObject.Find("bridge0");
        stage1_trigger = GameObject.Find("stage1");
        stage1_door = GameObject.Find("stage1_door");
        GameObject[] mine_bot = new GameObject[7];
        bot1 = GameObject.Find("floorLight (4)");
        bot2 = GameObject.Find("floorLight (5)");
        bot3 = GameObject.Find("floorLight (3)");
        mine_bot[3] = GameObject.Find("mine_bot4");
        mine_bot[4] = GameObject.Find("mine_bot5");
        mine_bot[5] = GameObject.Find("mine_bot6");
        mine_bot[6] = GameObject.Find("mine_bot7");
        bridge1 = GameObject.Find("bridge1");
        GameObject[] bot = new GameObject[7];
        bot[0] = GameObject.Find("bot1");
        bot[1] = GameObject.Find("bot2");
        bot[2] = GameObject.Find("bot3");
        bot[3] = GameObject.Find("bot4");
        bot[4] = GameObject.Find("bot5");
        stage2_door = GameObject.Find("stage2_door");
        bridge2 = GameObject.Find("bridge");
        final_door = GameObject.Find("final_door");
        final_item = GameObject.Find("final_item");
        posR = new Vector3(transform.position.x + (posM_x - posR_x), transform.position.y, transform.position.z + (posM_z - posR_z));
    }

    void OnTriggerEnter(Collider collider) {
        if (wait && collider.tag =="start_point")
        {
            wait = false;
            start = true;
            tempvector1 = start_point1.transform.position;
            tempvector1.x = tempvector1.x - 10.6f;
            start_point1.transform.position = Vector3.Lerp(start_point1.transform.position, tempvector1, speed * Time.deltaTime);
            tempvector2 = start_point2.transform.position;
            tempvector2.x = tempvector2.x + 10.6f;
            start_point2.transform.position = Vector3.Lerp(start_point2.transform.position, tempvector2, speed * Time.deltaTime);
        }
        else if (start && collider.tag == "stage1")
        {
            start = false;
            stage1 = true;
            tempvector = bridge2.transform.position;
            tempvector.x = tempvector.x - 130.5f;
            bridge2.transform.position = Vector3.Lerp(bridge2.transform.position, tempvector, speed * Time.deltaTime);
            bot1.SetActive(false);
            bot2.SetActive(false);
            bot3.SetActive(false);
            //mine_bot[1]
            //mine_bot[2]
        }
        else if (stage1 && collider.tag == "fly")
        {
            gameObject.SetActive(false);
            music.Stop();
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
