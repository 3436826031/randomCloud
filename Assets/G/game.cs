using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkAttribute{

    public LinkAttribute linkAttribute;
    public  string itemId;
    public string unionId;

    public string nodeId;

    public  Event unionEvent;

    public LinkAttribute(){
        linkAttribute=new  LinkAttribute(); 
        return linkAttribute;
    }


   

    public LinkAttribute setItemId(string itemId){
        this.itemId=itemId;
        return linkAttribute;
    }

 
    public LinkAttribute setUnionId(string unionId){
        this.unionId=unionId;
        return linkAttribute;
    }

   
   public LinkAttribute setNodeId(string nodeId){
        this.nodeId=nodeId;
        return linkAttribute;
    }

  
 public LinkAttribute setUnionEvent(Event unionEvent){
        this.unionEvent=unionEvent;
        return linkAttribute;
    }

     

}
public class ItemAttribute{

     public  Vector3 position;
     public string  word;
     public Color color;

      public ItemAttribute itemAttribute;

    public ItemAttribute(){
            itemAttribute=new  ItemAttribute(); 
            return itemAttribute;
        }

 public ItemAttribute setPosition(Vector3 position){
        this.position=position;
        return itemAttribute;
    }

 public ItemAttribute setWord(string word){
        this.word=word;
        return itemAttribute;
    }
 
 public ItemAttribute setColor(Color color){
        this.color=color;
        return itemAttribute;
    }
}


public class WordItem : MonoBehaviour
{

    public Text text;
    
    public LinkAttribute linkAttribute;

    public ItemAttribute itemAttribute;


   

    //接下来要写一个碰撞的事件，还是说射线检测呢，拖拽融合的基本逻辑


    // 相机的逻辑
    // thisItem, coverItem
    // 等一下咋操作 点击相机，就是相机生成的第一个点  喀  拖动，改变第二个点的位置 ，一条实时生成的线条，涉嫌检测，图层 嚓
    // 

    public void Unit(){
        unionEvent.event();
    }

    public void flushShow(){

    }


    /**初始化 */
    public void init(ItemAttribute itemAttribute,LinkAttribute linkAttribute){
        if(itemAttribute!=null){
            this.itemAttribute=itemAttribute;
            transform.position=itemAttribute.position;
            text.text=itemAttribute.word;
        }

        if(linkAttribute!=null){
           this.linkAttribute=linkAttribute;
        }
       
       

       
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
    [MyRangeAttribute(0,1f,"文字显示的速度")]
    public float delay = 0.1f;
    private string fullText="测试信息";
    private string currentText = "";
    private Text textObject;

    public GameObject wordItemPre;

    private string textGroup;

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
     //   StartCoroutine(ShowText());
    }

    
    public  void HadeUp(){

        StopCoroutine(ShowText());
        //接下来要阅读的文本
        fullText=fullText.Substring(readIdx,fullText.length-1);

        //接下来就是算时间了，不进行清空
        //我需要计算好，不能用DoTewwn了 ‘相机’ 


    }



    public void HadeDown(){
         StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {


        while(readIdx<fullText.Length){
            currentText = fullText.Substring(0, readIdx);
            bool isGroup;

           
            string a = fullText.Substring(readIdx-1, readIdx)

            if(a.equals("‘")){
                //特殊词汇的组词开始
               int startGroupIdx=readIdx; 
            }

             if(a.equals("’")){
                //特殊词汇的组词开始
               int endGroupIdx=readIdx; 
            }


            if(currentText.Constant("‘’")){
               string textGroup=fullText.Substring(startGroupIdx, endGroupIdx); 
               createGroup(textGroup);
            }


            readIdx++;
             textObject.text = currentText;
           yield return new WaitForSeconds(delay);

        }
       
    }
    
    //创造词组的预制体
    void createGroup(string textGroup){

        if(textGroup.equals("相机")){
            // 好像复杂很多，直接生成一个新的预制体，然后赋值
        LinkAttribute linkAtt=new LinkAttribute().setItemId().setNodeId().setUnionId();
        ItemAttribute itemAtt=new ItemAttribute().setPosition()

        PrefabFactory.createTextPrefab(wordItemPre,itemAtt,linkAtt);
        }


    }

    //要考虑生成的位置，对象池

    
}


public class PrefabFactory{

    //写一个单例


    void Start(){


    }



    public static GameObject createTextPrefab(GameObject gm,ItemAttribute itemAttribute,LinkAttribute linkAttribute){

     GameObject pre=  Instantiate(prefab);
     WordItem wi= pre.GetComponent<WordItem>();
     wi.init(itemAttribute,linkAttribute);    
    return pre;
    }

}