using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationManger : MonoBehaviour
{

    //��Ҫ�����ĵ�
    public GameObject dian;
    // Start is called before the first frame update
    
    public GameObject icon;
    



    void Start()
    {

        Vector2 position = new Vector2();



    }

    // Update is called once per frame
    void Update()
    {

        //��������  

        Vector2 pos=  CalculateIntersection(dian.transform.position.x, dian.transform.position.y, UnityEngine.Screen.width, UnityEngine.Screen.height);
        icon.transform.position = pos;

        print(pos);





    }



    /// <summary>
    /// �õ�����Ļ������λ�õ���Ļ���ĵ����ߡ�����Ļ�߽�Ľ��㣬�޷������Ľǡ�
    /// </summary>
    /// <param name="x">����X����</param>
    /// <param name="y">����Y����</param>
    /// <param name="width">��Ļ���</param>
    /// <param name="height">��Ļ�߶�</param>
    /// <returns></returns>
    /// ֱ�ӷ���һ������
    private static Vector2 CalculateIntersection(float x, float y, float width, float height)
    {


        //x��y��
        Vector2 position = new Vector2();

        position.x = x;
        position.y = y;
       
        //  0< y < height
        if (0 <= y && y <= height)
        {
            //˵������Ļ����࣬xһ����0
            if (x < 0)
            {
                position.x = 0;
                position.y = height / 2 + (y - (height / 2)) * (width / 2) / (width / 2 - x);

                /** ������ ����߶�
                 * ��Ļ�ĸ߶� /2 �� �������y - ��Ļ�ĸ߶� /2�� �� ����Ļ�Ŀ��/2�� �� ����Ļ�Ŀ��/2 -�����x�� 
                 */

            }
            //��Ļ�Ҳ�
            else if (x > width)
            {
                position.x = width;
             
                position.y = height / 2 + (y - (height / 2)) * (width / 2) / (x - width / 2);
            }

        }
        //  0 < x < width
        else if (0 <= x && x <= width)
        {

            if (y < 0)
            {
                position.y = 0;
                position.x = width / 2 + (x - (width / 2)) * (height / 2) / (height / 2 - y);
            }
            else if (y > height)
            {
                position.y = height;
                position.x = width / 2 + (x - (width / 2)) * (height / 2) / (y - height / 2);
            }
        }


        else//�Ľǵ���Σ�
        {
            position.x = x < 0 ? 0 : width;
            position.y = y < 0 ? 0 : height;
        }

        return position;
    }

}
