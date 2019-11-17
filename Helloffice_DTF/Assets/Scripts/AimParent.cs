using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AimParent : MonoBehaviour
{
   

    [SerializeField]
    public int Number_of_Players = 4;



    public int all_at_aim = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (all_at_aim == Number_of_Players * 2)
        {
            LevelRestart();
        }
        //Debug.Log(all_at_aim);
    }

    void LevelRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
