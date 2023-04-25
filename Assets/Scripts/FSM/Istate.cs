using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//状态的生命周期
public interface  Istate 
{

    void OnUpdate();
    
    void OnEnter();

    void OnExit();


}
