using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonObject : MonoBehaviour ,IPointerDownHandler,
                            IPointerUpHandler,
                            IPointerEnterHandler,
                            IPointerExitHandler
{
    public delegate void _callback(GameObject go);
    public delegate void _callbackstr(string data);
    public Action call = null;
    public _callback callback = null;
    public _callbackstr callbackstr = null;
    public bool m_init = false;

    public string CallData = null;


    public void OnPointerDown(PointerEventData eventData)
    {

        if (callback!=null)
        {
            callback(gameObject);
        }
        if (callbackstr!=null)
        {
            callbackstr(CallData);
        }
        if (call!=null)
        {
            call();
        }

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
       // Debug.Log("enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
       // Debug.Log("exit");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
       // Debug.Log("up");
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public static ButtonObject Get(GameObject go)
    {
        ButtonObject load = go.GetComponent<ButtonObject>();
        if (load == null) load = go.AddComponent<ButtonObject>();
        return load;
    }
    public static ButtonObject Get(GameObject go,string calldata)
    {
        ButtonObject load = go.GetComponent<ButtonObject>();
        if (load == null) load = go.AddComponent<ButtonObject>();
        load.CallData = calldata;
        return load;
    }
}
