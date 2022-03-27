using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenario_Manager : MonoBehaviour
{
    public Scenario_Data manager_component;
    void Start()

    {
        manager_component.manager_Delegate += SequenceClear;

    }

    public void SequenceClear()

    {
        manager_component.index++;
    }
}
