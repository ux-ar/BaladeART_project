using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class RunningData : MonoBehaviour
{
    public int index;
    public List<int> listIndex = new List<int>();

    public int defineRunningIndex(List<ARObjectData> dataList)
    {
        return index;
    }
    public void defineList(bool monument, bool oeuvre, List<ARObjectData> dataList)
    {
        if (monument)
        {
            if (oeuvre)
            {
                for (int i = 0; i < dataList.Count; i++)
                {
                    listIndex.Add(dataList[i].id);
                }

            }
            else
            {
                for (int i = 0; i < dataList.Count; i++)
                {
                    if (dataList[i].isMonument)
                    {
                        listIndex.Add(dataList[i].id);
                    }
                }
            }
        }
        else
        {
            for (int i = 0; i < dataList.Count; i++)
            {
                if (dataList[i].isOeuvre)
                {
                    listIndex.Add(dataList[i].id);
                }
            }
        }
    }


}
