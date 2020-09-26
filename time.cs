using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI; //使用Unity UI程式庫。

public class time : MonoBehaviour
{

    int time_int = 5;

    public Text time_UI;

    void Start()
    {

        InvokeRepeating("timer", 1, 1);

    }

    void timer()
    {

        time_int -= 1;

        time_UI.text = time_int-1 + "";

        if (time_int == 1)
        {

            time_UI.text = "Go";

        }
        if(time_int == 0)
        {
            time_UI.text = " ";
            CancelInvoke("timer");
        }

    }

}