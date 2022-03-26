using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ScenarioData : MonoBehaviour
{
    public TextAsset jsonData;
    public ScenarioDataList sd;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DataSet());
    }

    IEnumerator DataSet()
    {
        sd = JsonUtility.FromJson<ScenarioDataList>(jsonData.text);
        yield return null;
    }

    /*
    ScenarioDataList GetData(string sd)
    {
        return JsonUtility.FromJson<ScenarioDataList>(sd);
    }
    */

}

public class ScenarioDataList
{
    public List<BehaviourData> data;
}

public class BehaviourData
{
    public string ID;
    public string BEHAVIOUR_TYPE;
    public string GOAL_DATA_1;
    public string GOAL_DATA_2;
    public string GOAL_HL;

}
