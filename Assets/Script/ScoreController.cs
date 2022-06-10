using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text skorKiri;
    public Text skorKanan;

    public ScoreManager Manager;

    // Update is called once per frame
    void Update()
    {
        skorKiri.text = Manager.scoreKiri.ToString();
        skorKanan.text = Manager.scoreKanan.ToString();
    }
}
