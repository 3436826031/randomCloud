using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Pathfinding;
using DG.Tweening;


/// <summary>
/// 敌人的各项属性
/// </summary>
[Serializable]
public class Attribute {
 

}

//状态类型
public enum StateType { Search, Track ,Att} 



public class FSM : MonoBehaviour
{
  //字典
    public Dictionary<StateType, Istate> states = new Dictionary<StateType, Istate>();

   //属性
    public Attribute attribute;
     [Header("当前状态")]
    private Istate currentState;



    void Awake(){
        states.Add(StateType.Track, new Track(this));
        states.Add(StateType.Search, new Search(this));
        states.Add(StateType.Att, new Att(this));
    }



    void Start()
    {
          TransitionState(StateType.Search);
    }

    // Update is called once per frame
    void Update()
    {
     
        if (currentState != null) {
            currentState.OnUpdate();
        }
    }

   

    //切换状态
    public void TransitionState(StateType type)
    {
        if (currentState != null)
            currentState.OnExit();
        currentState = states[type];
        currentState.OnEnter();
    }

 


}
