using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenario_Data : MonoBehaviour
{
    //��������Ʈ ����
    public delegate void ManagerDelegate();
    public ManagerDelegate manager_Delegate;

    public int index = 0;
}
