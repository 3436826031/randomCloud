using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;




public class HookManger : MonoBehaviour
{

    //���ӵĳ���
    public float length;

    public GameObject hookHeader;

    public LineRenderer line;

    public float speed;
    /**
     * -ץ���Ļ���˼·
     * ����һ�����壬��ǰ����һ�εľ���
     * ʹ��LineRender����ץ�����������֮������߼���
     * ���ӣ��ȴ�һ��ʱ�����û��ץ���κ�����Ļ����Զ��ջ�ץ���������Ʈ��������Ч��
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
        //���������Ķ˵���  2��
        line.SetVertexCount(2);

        //���������ص��λ��
        line.SetPosition(0, hookHeader.transform.position);
        






    }



    /**
     * �ջ�ץ��
     */
    void backHook() { 
        

        


    
    }







}
