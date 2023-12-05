using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    [SerializeField] TMP_Text Dialogue_Name;
    [SerializeField] TMP_Text Dialogue_Text;
    public int Dialogue_ID;
    [SerializeField] float speedText = 1;
    [SerializeField] List<Name_Text> text_1 = new List<Name_Text>();

    float timer;
    int characIndex = 0;

    void Start()
    {
        Change();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Dialogue_Text.text != text_1[Dialogue_ID].text)
            {
                Dialogue_Text.text = text_1[Dialogue_ID].text;
            }
            else if(Dialogue_ID < text_1.Count - 1 &&
                text_1[Dialogue_ID].ID != "Pregunta" &&
                text_1[Dialogue_ID].ID != "Muerte")
            {
                Dialogue_ID += 1;
                Change();
            }
        }
        if (Dialogue_Text.text != text_1[Dialogue_ID].text)
        {
            Write();
        }

        if (text_1[Dialogue_ID].ID == "Pregunta")
        {
            text_1[Dialogue_ID].Activable.showThis = text_1[Dialogue_ID].preguntas;
            text_1[Dialogue_ID].Activable.Activate();
        }
        if (text_1[Dialogue_ID].ID == "Scene")
        {
            text_1[Dialogue_ID].Activable.Activate();
        }
    }

    public void Change()
    {
        Dialogue_Name.text = text_1[Dialogue_ID].name;
        Dialogue_Text.text = null;
        characIndex = 0;
    }
    void Write()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer += speedText;
            characIndex++;
            Dialogue_Text.text = text_1[Dialogue_ID].text.Substring(0,characIndex);
        }
    }
}

[Serializable]
public class Name_Text
{
    public string ID;
    public string name;
    [TextArea] public string text;
    public GameObject preguntas;
    public Interaction Activable;
}
