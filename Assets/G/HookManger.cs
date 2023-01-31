using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;




public class HookManger : MonoBehaviour
{

    //绳子的长度
    public float length;

    public GameObject hookHeader;

    public LineRenderer line;

    public float speed;
    /**
     * -抓钩的基本思路
     * 设置一个物体，向前发射一段的距离
     * 使用LineRender绘制抓钩物体与玩家之间的连线即可
     * 附加：等待一段时间如果没有抓到任何物体的话，自动收回抓钩，最好有飘荡的物理效果
     * */


    public Vector2 dir;


    public Vector3 playerPos;


    // Start is called before the first frame update
    void Start()
    {

        playerPos = new Vector3(0, 0, 0);

        dir = new Vector2(1, 1);
        hookHeader.transform.DOLocalMove(dir * length, speed);
        
    }





    // Update is called once per frame
    void Update()
    {
        //设置线条的端点数  2个
        line.SetVertexCount(2);

        //设置起点和重点的位置
        line.SetPosition(0, hookHeader.transform.position);
        






    }



    /**
     * 收回抓钩
     */
    void backHook() { 
        

        


    
    }







}
