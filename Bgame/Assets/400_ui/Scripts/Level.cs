using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Level : BaseUI {

    [SerializeField]
    private GameObject Btn_BackMain;
    [SerializeField]
    private GameObject Btn_GoShop;

    
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
        ButtonObject.Get(Btn_BackMain).callback = OnClick;

    }
    public void OnClick(GameObject go)
    {
        string name = go.name;
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
