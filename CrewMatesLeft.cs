using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CrewMatesLeft : MonoBehaviour
{
    // Start is called before the first frame update
public TextMeshProUGUI left;
public int transfer;
public int enemiesleft = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transfer = enemiesleft - GlobalVariableStorage.killcount;
       left.text = transfer.ToString();
    }
}
