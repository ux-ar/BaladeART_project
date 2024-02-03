using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class runningData
{
    public int index;
    public List<int> listIndex = new List<int>();

    public void defineList(bool monument, bool oeuvre, List<ARObjectData> arObjectDataList)
    {
        if (monument)
        {
            if(oeuvre)
            {
                for(int i = 0; i< arObjectDataList.Count; i++)
                {
                    listIndex.Add(arObjectDataList[i].id);
                }
                
            }
            else
            {
                for (int i = 0; i < arObjectDataList.Count; i++)
                {
                    if (arObjectDataList[i].isMonument)
                    {
                        listIndex.Add(arObjectDataList[i].id);
                    }
                }
            }
        }
        else
        {
            for (int i = 0; i < arObjectDataList.Count; i++)
            {
                if (arObjectDataList[i].isOeuvre)
                {
                    listIndex.Add(arObjectDataList[i].id);
                }
            }
        }
    }

    public int defineRunningIndex(List<ARObjectData> arObjectDataList)
    {
        return index;
    }
}
