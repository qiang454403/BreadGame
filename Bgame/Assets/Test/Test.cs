﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;

public class Test : MonoBehaviour {

    public Player Data = new Player();
    JsonWriter da = new JsonWriter();
    // Use this for initialization
    public GameObject rtt;
    void Start() {
        /*    da.WriteObjectStart();
            da.WritePropertyName("NAME");
            da.Write("gzq");
            da.WritePropertyName("AGE");
            da.Write(12);
            da.WriteObjectEnd();
            */
      
      
        
    }
   void dh(GameObject name)
    {
        Debug.Log("测试回调"+ name.name);
       
    }
    // Update is called once per frame
    void Update() {

    }
	public void Onclick()
	{
		print(11111);
	}
    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 100), "ss"))
        {
            //string res = da.ToString();
          //////  Player dd = new Player();
          ////  dd.NAME = "zz";
          //  dd.AGE = 21;
          //  string res = JsonMapper.ToJson(dd);
           // Data = LitJson.JsonMapper.ToObject<Player>(res);
            //Debug.Log(Data.NAME);
            //Debug.Log(Data.AGE);
        //    Debug.Log(res);

            UiManager.Instance.Add_Low("Login");
        }
    }
   
}
public class Player
{
    public string NAME;
    public int AGE = 0; 
}
