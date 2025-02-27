﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class StartCursor : MonoBehaviour {

    [SerializeField] private TextMesh _textRecord;
    private float _record;

    public const float __X_START_CURSOR = -2.0f;
    public const float __Y_START_CURSOR = 0.3f;

    private Transform trans;
    private int menuItem;
    private bool menuOption;

	// Use this for initialization
	void Start () {
        trans = transform;
        menuOption = true;

        _record = PlayerPrefs.GetFloat("highScore", _record);
        _textRecord.text = _record.ToString();
               
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetButtonDown("Vertical"))
        {
            if(Input.GetAxis("Vertical") > 0f)
            {
                menuItem--;
                if (menuItem < 0)
                    menuItem = 0;
                    menuOption = true;
            }
            if(Input.GetAxis("Vertical") < 0f)
            {
                menuItem++;
                if (menuItem > 1)
                    menuItem = 1;
                    menuOption = false;
            }
        }

        trans.position = new Vector3(__X_START_CURSOR, __Y_START_CURSOR - menuItem * 2f, 0f);
        
        if (Input.GetKeyDown(KeyCode.Space) && (menuOption == true))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
            //PlayerPrefs.DeleteKey("highScore");
        }
        else if (menuOption == false && (Input.GetKeyDown(KeyCode.Space)))
        {
            Application.Quit();
        }

    }
    public int MenuItem { get { return menuItem; } }
}
