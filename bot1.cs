using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bot1 : MonoBehaviour {

    private int delaytime;
    private int where;
    private float time;
    public float posR_x;
    public float posR_z;
    public float posM_x;
    public float posM_z;
    public float posL_x;
    public float posL_z;
    public float Default_y;
    private Vector3 posR;
    private Vector3 posM;
    private Vector3 posL;
    float speed = 3.0f;
    public int HP;

    // Use this for initialization
    void Start () {
        delaytime = 1;
        where = 2;
        posR= new Vector3(transform.position.x+(posM_x - posR_x), transform.position.y, transform.position.z+(posM_z - posR_z));
        posM = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        posL = new Vector3(transform.position.x + (posM_x - posL_x), transform.position.y, transform.position.z + (posM_z - posL_z));
        HP = 65;
    }

    void onTriggerEnter(Collider col) {
        
            HP -= 5;
            col.gameObject.SetActive(false);

    }

    void random()
    {
        int temp = Random.Range(0, 3);
        while (where == temp)
        {
            temp = Random.Range(0, 3);
        }
        where = temp;
    }

	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (time >= delaytime)
        {
            random();
            time = 0.0f;
        }
        else
        {
            if (where == 0)
            {
                //gameObject.transform.position =new Vector3(posR_x, Default_y, posR_z);
                transform.position = posR;
            }
            else if (where == 1)
            {
                //gameObject.transform.position = new Vector3(posM_x, Default_y, posM_z);
                transform.position = posM;
            }
            else if (where == 2)
            {
                //gameObject.transform.position = new Vector3(posL_x, Default_y, posL_z);
                transform.position = posL;
            }
        }
        if (HP <= 0) {
            gameObject.SetActive(false);
        }
    }
}
