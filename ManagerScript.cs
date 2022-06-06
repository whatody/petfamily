using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    [Header("Start")]
    public GameObject StartImage;
    public GameObject StartImageBtnGroup;
    public GameObject StartImageBtnGroup2;
    public GameObject WriteImage;

    [Header("Main")]
    public GameObject MainImage;
    public GameObject MainBtnGroup;


    [Header("Poo")]
    public GameObject PooImage;
    public GameObject PooBtnGroup;

    [Header("Entrance")]
    public GameObject EntranceImage;
    public GameObject EntranceBtnGroup;

    [Header("Feeding")]
    public GameObject FeedingImage;
    public GameObject FeedingBtnGroup;

    private void Start()
    {
        InitObj();
        LoadStart();
    }

    public void InitObj()
    {
        //시작화면 구성요소 비활성화
        StartImage.SetActive(false);
        StartImageBtnGroup.SetActive(false);
        StartImageBtnGroup2.SetActive(false);
        WriteImage.SetActive(false);

        // 메인화면 구성요소 비활성화
        MainImage.SetActive(false);
        MainBtnGroup.SetActive(false);

        //밥 구성요소 비활성화
        FeedingImage.SetActive(false);
        FeedingBtnGroup.SetActive(false);

        // 화장실 구성요소 비활성화
        PooImage.SetActive(false);
        PooBtnGroup.SetActive(false);

        // 산책 구성요소 비활성화
        EntranceImage.SetActive(false);
        EntranceBtnGroup.SetActive(false);
    }

    //시작화면
    public void LoadStart()
    {
        InitObj();
        StartImage.SetActive(true);
        StartImageBtnGroup.SetActive(true);
    }

    public void LoadName()
    {
        InitObj();
        StartImageBtnGroup2.SetActive(true);
        WriteImage.SetActive(true);
    }

    // 메인화면
    public void LoadMain()
    {
        InitObj();
        MainImage.SetActive(true);
        MainBtnGroup.SetActive(true);

    }

    //밥 화면
    public void LoadFeeding()
    {
        InitObj();
        FeedingImage.SetActive(true);
        FeedingBtnGroup.SetActive(true);
    }
    //화장실화면
    public void LoadPoo()
    {
        InitObj();
        PooImage.SetActive(true);
        PooBtnGroup.SetActive(true);
    }

    // 산책 화면
    public void LoadEntrance()
    {
        InitObj();
        EntranceImage.SetActive(true);
        EntranceBtnGroup.SetActive(true);
    }

}
