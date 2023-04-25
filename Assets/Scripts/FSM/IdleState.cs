using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

using DG.Tweening;
using System;
public class IdleState : MonoBehaviour
{



}


 
public class Att : Istate
{
    public FSM message;
    public EmenyAttribute attribute;



    public Att(FSM fsm)
    {
        this.message = fsm;
        this.attribute = fsm.attribute;

    }
    public bool isAtt;

    public void OnEnter()
    {

    }


   


    public void OnExit()
    {
       
    }

    public void OnUpdate()
    {
        message.StopAtt();

    }
}





/// <summary>
/// 追踪模式
/// </summary>
public class Track : Istate
{


    public FSM message;
    public EmenyAttribute attribute;

   
    public Track(FSM fsm)
    {
        this.message = fsm;
        this.attribute = fsm.attribute;

    }

    public void OnEnter()
    {

    }

    public void OnExit()
    {
       // throw new System.NotImplementedException();
    }

    public void OnUpdate() {

    }


}




/// <summary>
/// 搜索模式
/// </summary>
public class Search : Istate
{


    public FSM message;
    public EmenyAttribute attribute;


    public Search(FSM fsm)
    {
        this.message = fsm;
        this.attribute = fsm.attribute;

    }

    public void OnEnter()
    {

    }

    public void OnExit()
    {
       
    }



    public void OnUpdate()
    {

    }


}
