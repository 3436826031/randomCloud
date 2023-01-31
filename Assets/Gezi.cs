using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gezi : MonoBehaviour
{
    
    public GameObject zuo;

    public GameObject you;

    public GameObject shang;

    public GameObject xia;


    /**
     *  其实折叠只有两种规则 四个鸽子
     *  
     **/
    public void xuanz(int type) {


        if (type == 0)
        {
            if (gameObject.transform.rotation.eulerAngles != new Vector3(0, 90, 0))
            {
                gameObject.transform.RotateAround(zuo.transform.position, new Vector3(0, 1, 0), 5);
            }

        }
        else if(type==1){
            if (gameObject.transform.rotation.eulerAngles != new Vector3(0, 90, 0))
            {
                gameObject.transform.RotateAround(you.transform.position, new Vector3(0, 1, 0), 5);
            }



        }
        else if (type == 2)
        {
            if (gameObject.transform.rotation.eulerAngles != new Vector3(0, 90, 0))
            {
                gameObject.transform.RotateAround(xia.transform.position, new Vector3(0, 1, 0), 5);
            }



        }
        else if (type == 3)
        {
            if (gameObject.transform.rotation.eulerAngles != new Vector3(0, 90, 0))
            {
                gameObject.transform.RotateAround(shang.transform.position, new Vector3(0, 1, 0), 5);
            }



        }


        //  gameObject.transform.Rotate(new Vector3(0,50,0),Space.Self);


        //  RotateRound(transform.position,dian.transform.position,new Vector3(0,90,0),90);


    }


    // Start is called before the first frame update
    void Start()
    {
        xuanz(0);
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.A)) {
            //向左折叠

            xuanz(0);


        }

        if (Input.GetKeyDown(KeyCode.D)) {
            //向右折叠 

            xuanz(1);


        }








        xuanz(0);

        
    }



    /// <summary>
     /// 围绕某点旋转指定角度
     /// </summary>
     /// <param name="position">自身坐标</param>
     /// <param name="center">旋转中心</param>
     /// <param name="axis">围绕旋转轴</param>
     /// <param name="angle">旋转角度</param>
     /// <returns></returns>
    public Vector3 RotateRound(Vector3 position, Vector3 center, Vector3 axis, float angle)
    {
        return Quaternion.AngleAxis(angle, axis) * (position - center) + center;
    }

}
