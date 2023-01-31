using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationManger : MonoBehaviour
{

    //需要导航的点
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

        //两点连线  

        Vector2 pos=  CalculateIntersection(dian.transform.position.x, dian.transform.position.y, UnityEngine.Screen.width, UnityEngine.Screen.height);
        icon.transform.position = pos;

        print(pos);





    }



    /// <summary>
    /// 得到【屏幕外物体位置到屏幕中心的连线】与屏幕边界的交点，无法过渡四角。
    /// </summary>
    /// <param name="x">物体X坐标</param>
    /// <param name="y">物体Y坐标</param>
    /// <param name="width">屏幕宽度</param>
    /// <param name="height">屏幕高度</param>
    /// <returns></returns>
    /// 直接返回一个坐标
    private static Vector2 CalculateIntersection(float x, float y, float width, float height)
    {


        //x和y轴
        Vector2 position = new Vector2();

        position.x = x;
        position.y = y;
       
        //  0< y < height
        if (0 <= y && y <= height)
        {
            //说明在屏幕的左侧，x一定是0
            if (x < 0)
            {
                position.x = 0;
                position.y = height / 2 + (y - (height / 2)) * (width / 2) / (width / 2 - x);

                /** 三角形 计算高度
                 * 屏幕的高度 /2 加 （物体的y - 屏幕的高度 /2） 乘 （屏幕的宽度/2） 除 （屏幕的宽度/2 -物体的x） 
                 */

            }
            //屏幕右侧
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


        else//四角当如何？
        {
            position.x = x < 0 ? 0 : width;
            position.y = y < 0 ? 0 : height;
        }

        return position;
    }

}
