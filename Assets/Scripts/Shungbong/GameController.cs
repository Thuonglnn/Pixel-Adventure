using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    public GameObject matcuoi;
    public float thoigian;
    float m_thoigian;
    int diem;
    bool isGameOver;
    UIManager uimanager;

    // Start is called before the first frame update
    void Start()
    {
        //taoMatCuoi();
        m_thoigian=0;
        uimanager = FindAnyObjectByType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {

    if(isGameOver==true)
    {
        m_thoigian = 0;
        Debug.Log("ket thuc game");
        uimanager.showGameoverPanel(true);
        return;
    }









        m_thoigian -= Time.deltaTime;
        if(m_thoigian <= 0)
        {
            taoMatCuoi();
            m_thoigian=thoigian;
        }
    }


    public void SetDiem(int diem)
    {
        this.diem = diem;
    }

    public int getDiem()
    {
        return diem;
    }
    
    public void tangDiem()
    {
        diem++;
        uimanager.setScoreText("Diem : " + diem);
    }

    public void setTrangThai(bool trangthai)
    {
        isGameOver = trangthai;
    }


public void taoMatCuoi()
{
    Vector2 vitri = new Vector2(Random.Range(-9.2f,9.2f),6);
    if(matcuoi==true)
    {
        Instantiate(matcuoi,vitri,Quaternion.identity);
    }
}

public void Replay()
{
    diem = 0;
    isGameOver = false;
    uimanager.setScoreText("Diem: "+ diem);
    uimanager.showGameoverPanel(false);
}


}
