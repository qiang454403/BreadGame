using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : BaseUI {

    // Use this for initialization
    [SerializeField]
    private GameObject btn_Start;
    [SerializeField]
    private GameObject btn_Shop;
    [SerializeField]
    private GameObject btn_Exit;

    void Start() {
        Init();
    }

    // Update is called once per frame
    void Update() {

    }
    public override void Init()
    {
        base.Init();



        //btn_Start.onClick.AddListener(delegate() { OnClick("GoLevel"); });
        // btn_Shop.onClick.AddListener(delegate() {OnClick("GoShop"); });
        ButtonObject.Get(btn_Start).callback = OnClick;
        
    }
    public override void Destroy()
    {
        base.Destroy();

    }
    public void OnClick(GameObject _ToName)
    {
        string ToName = _ToName.name;

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
