using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interaction : ScriptableObject
{
    public GameObject showThis;
    public virtual void Activate() { }
}

[CreateAssetMenu] //Mostrar preguntas
public class Show : Interaction
{
    public override void Activate()
    {
        showThis.SetActive(true);
    }
}

[CreateAssetMenu] //Iniciar combate
public class Fight : Interaction
{
    public int sceneNumber;
    public override void Activate()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
