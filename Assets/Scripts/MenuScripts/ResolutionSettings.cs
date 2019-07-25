using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ResolutionSettings : MonoBehaviour
{
    public Dropdown dropdown;
    Resolution[] resolution;

    // Start is called before the first frame update
    void Start()
    {
        //Переменные связанные с разрешенинм экрана
        resolution = Screen.resolutions;
        string[] strRes = new string[resolution.Length];
        int currentSResl = 0; 

        for (int i = 0; i < resolution.Length; i++)
        {
            strRes[i] = resolution[i].width.ToString() + "x" + resolution[i].height.ToString();
            if (Screen.currentResolution.width == resolution[i].width && Screen.currentResolution.height == resolution[i].height)
            {
                currentSResl = i;
            }
        }

        dropdown.ClearOptions(); 
        dropdown.AddOptions(strRes.ToList());
        dropdown.value = currentSResl; 

    }

    public void SetResolution()
    {
        Screen.SetResolution(resolution[dropdown.value].width
            , resolution[dropdown.value].height, true);
    }
}
