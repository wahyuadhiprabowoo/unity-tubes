using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    float time, second;
    [SerializeField]
    public Image FillImage;
    // Start is called before the first frame update
    void Start()
    {
        second = 5;
        Invoke("LoadGame", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(time < 5){
            time += Time.deltaTime;
            FillImage.fillAmount = time/second;
        }
    }
    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
}
