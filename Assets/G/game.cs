using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attribute{

     string itemId;
    string unionId;
    Event unionEvent;

}


public class game : MonoBehaviour
{
    string itemId;
    string unionId;

    string nodeId;

    string connectNodeId;

    Event unionEvent;

    //接下来要写一个碰撞的事件，还是说射线检测呢，拖拽融合的基本逻辑


    //相机的逻辑
    // thisItem, coverItem
    // 等一下咋操作 点击相机，就是相机生成的第一个点  喀  拖动，改变第二个点的位置 ，一条实时生成的线条，涉嫌检测，图层 嚓




    public void Unit(){
        unionEvent.event();
    }

    void flushShow(){



    }

}


public class Event{
    //事件本身的方法
    public void event(){
        //缩小，自己，改变另一个属性，还是生成一个新的呢，emmmm，
        // 改写另一个物体的属性，融合是一个固定的逻辑吗
        
        
    }



    switch (value)
    {
        case "1":
            break;
        default:
            break;
    }
    

}


public class FilmCerameItem{

    //
    string[] compose={};





}




using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TypewriterEffect : MonoBehaviour
{
    public float delay = 0.1f;
    private string fullText="测试信息";
    private string currentText = "";
    private Text textObject;


    private int readIdx;

    //停止协程


    //点击就是开始携程
    //一旦松开手，就停止协程，停止携程的同时，几下当前的坐标，
    //fullText就行从上次停止的地方，分隔，重新开始这个协程
    //

    void Start()
    {
        textObject = GetComponent<Text>();
        fullText = textObject.text;
        textObject.text = "";
        StartCoroutine(ShowText());
    }

    
    void HadeUp(){

        StopCoroutine(ShowText());
        //接下来要阅读的文本
        fullText=fullText.Substring(readIdx,fullText.length-1);


    }


    IEnumerator ShowText()
    {


        while(readIdx<fullText.Length){
            currentText = fullText.Substring(0, readIdx);
            readIdx++;
             textObject.text = currentText;
        yield return new WaitForSeconds(delay);

        }
       
    }

    
}