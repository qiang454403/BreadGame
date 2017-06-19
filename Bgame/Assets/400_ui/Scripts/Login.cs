using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : BaseUI {

    // Use this for initialization
    [SerializeField]
    private Button btn_Start;
    [SerializeField]
    private Button btn_Shop;
    [SerializeField]
    private Button btn_Exit;

    void Start() {
        Init();
    }

    // Update is called once per frame
    void Update() {

    }
    public override void Init()
    {
        base.Init();

        btn_Start.onClick.RemoveAllListeners();
        btn_Shop.onClick.RemoveAllListeners();
        btn_Exit.onClick.RemoveAllListeners();

        btn_Start.onClick.AddListener(delegate() { OnClick("GoLevel"); });
        btn_Shop.onClick.AddListener(delegate() {OnClick("GoShop"); });
        
    }
    public override void Destroy()
    {
        base.Destroy();

    }
    public void OnClick(string ToName)
    {
        if (ToName == "GoLevel")
        {
            UiManager.Instance.OpenFace("Level");
            base.Close();
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
