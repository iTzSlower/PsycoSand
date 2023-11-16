using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blackscreen : MonoBehaviour
{
    [SerializeField] bool show;
    [SerializeField] Image screen;
    [SerializeField] _screen state;
    float timer = 1;

    enum _screen
    {
        show, none, hide
    }
    void Start()
    {
        if (show)
        {
            screen.fillAmount = 1;
            state = _screen.show;
            show = false;
        }
    }
    void Update()
    {
        switch (state)
        {
            case _screen.none:
                nothing();
                break;

            case _screen.show:
                Show();
                break;

            case _screen.hide:
                Hide();
                break;
        }
    }
    void Show()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime * 1.1f;
            screen.fillAmount = timer / 1;
        }
        else
        {
            state = _screen.none;
        }
    }
    void nothing()
    {
        timer = 0;
        screen.fillAmount = 0;
    }

    public void Hide()
    {
        if (timer < 1)
        {
            timer += Time.deltaTime * 1.1f;
            screen.fillAmount = timer / 1;
        }
        else
        {
            //Change Scene
        }
    }
}
