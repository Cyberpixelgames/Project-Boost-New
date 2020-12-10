using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKey("space") )
        {
            Invoke("LoadFirstLevel", .1f);
        }
    }

    void LoadFirstLevel()
    {
        SceneManager.LoadScene(1);
    }
}
