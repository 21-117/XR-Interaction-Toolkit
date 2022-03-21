using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenario_Data : MonoBehaviour
{
    //델리게이트 설정
    public delegate void ManagerDelegate();
    public ManagerDelegate manager_Delegate;

    public int index = 0;
}
