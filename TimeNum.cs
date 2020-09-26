using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeNum : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            float intime = KinectManager.nowTime;
            if (intime > 20.0f)
            {
                //Debug.Log("finish");
                GameObject.Find("finish").GetComponent<UnityEngine.UI.Text>().text = "恭喜!完成時間為" + intime.ToString("F1");
            }
        }
    }
}
