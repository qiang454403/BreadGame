using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : BaseUI {

    // Use this for initialization
    private Button btn_Start;
    private Button btn_Shop;
    private Button btn_Exit;

    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    public override void Init()
    {
        base.Init();
        
    }
    public override void Destroy()
    {
        base.Destroy();

    }
    public void OnClick(string ToName)
    {
        if (ToName == "GoLevel")
        {
            Debug.Log("去关卡");

        }
        else if (ToName == "GoShop")
        {
            Debug.Log("去商店");
        }
        else if (ToName == "设置")
        {
            Debug.Log("退出游戏");
        }
    }
}
