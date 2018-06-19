using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bot2 : MonoBehaviour {
    private int delaytime;
    private bool where;
    private float time;
    public float start_x;
    public float start_z;
    public float end_x;
    public float end_z;
    public float Default_y;
    public int HP;
    private Vector3 posStart;
    private Vector3 posEnd;
    float speed = 3.0f;
    
        // Use this for initialization
        void Start()
        {
            delaytime = 2;
            where = false;
            posStart = new Vector3(transform.position.x , transform.position.y, transform.position.z);
            posEnd = new Vector3(transform.position.x - (start_x - end_x), transform.position.y, transform.position.z - (start_z - end_z));

        }

        // Update is called once per frame
        void Update()
        {
        time += Time.deltaTime;
        if (!where)
        {
            if (!transform.position.Equals(posEnd))
            {
                transform.position = Vector3.MoveTowards(transform.position, posEnd, 0.1f);
                transform.LookAt(posEnd);
                time = 0.0f;
            }
            else {
                if (time > delaytime)
                {
                    where = !where;
                }
            }
        }
        else {
            if (!transform.position.Equals(posStart))
            {
                transform.position = Vector3.MoveTowards(transform.position, posStart, 0.1f);
                transform.LookAt(posStart);
                time = 0.0f;
            }
            else
            {
                if (time > delaytime)
                {
                    where = !where;
                }
            }
        }

        }
    }



