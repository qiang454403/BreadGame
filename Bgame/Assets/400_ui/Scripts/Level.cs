using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : BaseUI {

    [SerializeField]
    private Button Btn_BackMain;
    [SerializeField]
    private Button Btn_GoShop;

    
	// Use this for initialization
	void Start () {
        Init();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public override void Init()
    {
        base.Init();
        Btn_BackMain.onClick.RemoveAllListeners();
        Btn_BackMain.onClick.AddListener(delegate() { OnClick("GoMain"); });

    }
    public void OnClick(string name)
    {
        if (name == "GoMain")
        {
            UiManager.Instance.OpenFace("Login");
            base.Close();
        }
        else if (name == "GoShop")
        {

        }
    }
}
