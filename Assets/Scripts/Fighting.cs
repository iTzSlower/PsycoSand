using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fighting : MonoBehaviour
{
    public Vector2 mouse;
    public List<Transform> objetivos = new List<Transform>();

    void Update()
    {
        mouse = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        
        Debug.Log(mouse.y - objetivos[1].position.y );



        if (objetivos.Count == 0)
        {
            win();
        }
        //else
        //{
        //    for (int i = 0; i < objetivos.Count; i++)
        //    {
        //        if ()
        //        {
        //            Destroy(objetivos[i]);
        //        }
        //    }
        //}
    }

    void win()
    {
        SceneManager.LoadScene("GANAR-CHARLA01-PREGUNTAS");
    }
    void Lose()
    {
        SceneManager.LoadScene("MUERTE01");
    }
}
