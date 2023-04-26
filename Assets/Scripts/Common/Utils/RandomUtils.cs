using System.Collections;
using System.Collections.Generic;
using UnityEngine;




namespace CloudX{

public class RandomUtils{


#region 概率随机数

    /// <summary>
    /// 指定概率随机数
    /// 参数示例[10,20,30] -> 解释为数组索引0.1.2产生概率分别为 17%, 33%,50%
    /// </summary>
    /// <param name="rate">几率数组（%）</param>
    /// <returns></returns>
    public static int RandArr(int[] rate)
    {
        // 求和
        int total = 1; // 随机数区间 [0,10) 左闭右开，所以初始值设置为1
        for (int i = 0; i < rate.Length; i++)
        {
            total += rate[i];
        }

        // 求随机
        int r = Random.Range(1, total);

        int t = 0;
        // 计算返回随机数组索引
        for (int i = 0; i < rate.Length; i++)
        {
            t += rate[i];
            if (r < t)
            {
                return i;
            }
        }

        return 0;
    }

    #endregion



}






}