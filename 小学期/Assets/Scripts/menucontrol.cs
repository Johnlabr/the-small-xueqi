using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menucontrol : MonoBehaviour
{
    // Start is called before the first frame update

    //整合
    public GameObject Landing_Floder;
    public GameObject Menu_Floader;
    public GameObject Player_floader;
    //登录
    public Button Landing_Btn;
    public InputField Management;
    public InputField password;

    //菜单
    public Button Select_role;
    public Button Report;
    public Button Tips;

    //选择角色
    public Button Administration;
    public Button Worker;
    public Button StartGame;
    private int A = 0;

    //登录转到菜单
    void LandingToMenu()
    {
        Landing_Floder.SetActive(false);
        Menu_Floader.SetActive(true);
    }
    //菜单转到选择角色
    void MenuToSelect()
    {
        Menu_Floader.SetActive(false);
        Player_floader.SetActive(true);
    }
    //跳转场景
    void JumpScene()
    {
        if (A == 1)
        {
            Debug.Log("管理组");
        }
        else
        {
            Debug.Log("员工组");
        }
    }
    //选择角色
    void ChooseAdministration()
    {
        A = 1;
    }
    void ChooseWorker()
    {
        A = 2;
    }
    void Start()
    {
        //初始化
        Landing_Floder.SetActive(true);
        Menu_Floader.SetActive(false);
        Player_floader.SetActive(false);

        //委托
        Landing_Btn.onClick.AddListener(() => LandingToMenu());
        Select_role.onClick.AddListener(() => MenuToSelect());
        StartGame.onClick.AddListener(() => JumpScene());
        Administration.onClick.AddListener(() => ChooseAdministration());
        Worker.onClick.AddListener(() => ChooseWorker());



    }

    // Update is called once per frame
    void Update()
    {

    }
}
