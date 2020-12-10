using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadData : MonoBehaviour
{
    public List<AttackClass> attack_data = new List<AttackClass>();
    // Start is called before the first frame update
    void Start()
    {
        TextAsset attacks = Resources.Load<TextAsset>("Text/Attacks - Sheet1");
        string[] data = attacks.text.Split(new char[] { '\n' });
        Debug.Log(data.Length);
        for (int i = 1; i < data.Length; i++)
        {
            string[] row = data[i].Split(new char[] { ',' });
            AttackClass a = new AttackClass();
            if (row[0] != "")
            {
                a.id = row[0];
                a.name = row[1];
                a.type = row[2];
                float.TryParse(row[3], out a.damage);
                float.TryParse(row[4], out a.accuracy);
                float.TryParse(row[5], out a.cost);
                attack_data.Add(a);
            }
        }
        foreach (AttackClass a in attack_data)
        {
            Debug.Log(a.name);
        }
    }
    
}
