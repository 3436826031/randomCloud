using System;

public class SingleBase<T> where T:new ()
{
    private static T intance;

    public static T Instance{

        get{
            if(Instance == null){
                instance=new T();
            }
            return Instance;
        }

    } 




}
