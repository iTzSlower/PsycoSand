using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Question : MonoBehaviour
{
    Dialogue di;
    void Start()
    {
        di = GetComponent<Dialogue>();
    }

    public void Answer(int i)
    {
        di.Dialogue_ID = i;
        di.Change();
    }
    public void Clear(GameObject g)
    {
        g.SetActive(false);
    }
    public void ChangeTransform(Transform a)
    {
        Camera.main.transform.position = a.position;
    }
    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
