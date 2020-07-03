using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SideMenuManager : MonoBehaviour
{
  //  public GameObject _SideMenu;
  //  public Text _info;
  //  public Button _TogleSideMenu;
    public Activate _content;
   // public Activate mcontent;


    public void TogleSideMenu()
    {
   //     _SideMenu.SetActive(!_SideMenu.activeInHierarchy);
    }

    public void OnItemSelect(int index)
    {
    //    _info.text = "Item " + index + " is selected";
        _content.ActivateSelectedModel(index);
    }

    

    //private void Start()
    //{
    //    _SideMenu.SetActive(false);
    //    _info.gameObject.SetActive(false);
    //    _TogleSideMenu.gameObject.SetActive(false);
    //}

    //public void OnARContentPlaced(Activate content)
    //{
    //    _SideMenu.SetActive(true);
    //    _info.gameObject.SetActive(true);
    //    _TogleSideMenu.gameObject.SetActive(true);
    //    _content = content;
    //  }
}
