using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class SpawnTile : MonoBehaviour
{
    public static SpawnTile Instance;
   
    public GameObject[,,] classSpawn;
    public GameObject spawn1, spawn2, spawn3, spawn4, spawn5;
    public List<gameobjImg> LstTile;
    public List<int> listID;
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        classSpawn = new GameObject[5, 8, 11];
       
       
       
        for (int i = 0; i < 70; i++)
        {
            classSpawn[0,spawn1.transform.GetChild(i).GetComponent<gameobjImg>().x, spawn1.transform.GetChild(i).GetComponent<gameobjImg>().y] = spawn1.transform.GetChild(i).gameObject;
            if (classSpawn[0,spawn1.transform.GetChild(i).GetComponent<gameobjImg>().x, spawn1.transform.GetChild(i).GetComponent<gameobjImg>().y].activeSelf== true)
            {
                LstTile.Add(spawn1.transform.GetChild(i).GetComponent<gameobjImg>());
            }
           
          
        }
      
        for (int i = 0; i < 88; i++)
        {
            classSpawn[1,spawn2.transform.GetChild(i).GetComponent<gameobjImg>().x, spawn2.transform.GetChild(i).GetComponent<gameobjImg>().y] = spawn2.transform.GetChild(i).gameObject;
            if (classSpawn[1,spawn2.transform.GetChild(i).GetComponent<gameobjImg>().x, spawn2.transform.GetChild(i).GetComponent<gameobjImg>().y].activeSelf == true)
            {
                LstTile.Add(spawn2.transform.GetChild(i).GetComponent<gameobjImg>());
            }
        }
        
        for (int i = 0; i < 70; i++)
        {
            classSpawn[2,spawn3.transform.GetChild(i).GetComponent<gameobjImg>().x, spawn3.transform.GetChild(i).GetComponent<gameobjImg>().y] = spawn3.transform.GetChild(i).gameObject;
            if (classSpawn[2,spawn3.transform.GetChild(i).GetComponent<gameobjImg>().x, spawn3.transform.GetChild(i).GetComponent<gameobjImg>().y].activeSelf == true)
            {
                LstTile.Add(spawn3.transform.GetChild(i).GetComponent<gameobjImg>());
            }
        }
     
        for (int i = 0; i < 88; i++)
        {
            classSpawn[3,spawn4.transform.GetChild(i).GetComponent<gameobjImg>().x, spawn4.transform.GetChild(i).GetComponent<gameobjImg>().y] = spawn4.transform.GetChild(i).gameObject;
            if (classSpawn[3,spawn4.transform.GetChild(i).GetComponent<gameobjImg>().x, spawn4.transform.GetChild(i).GetComponent<gameobjImg>().y].activeSelf == true)
            {
                LstTile.Add(spawn4.transform.GetChild(i).GetComponent<gameobjImg>());
            }
        }
       
        for (int i = 0; i < 70; i++)
        {
            classSpawn[4,spawn5.transform.GetChild(i).GetComponent<gameobjImg>().x, spawn5.transform.GetChild(i).GetComponent<gameobjImg>().y] = spawn5.transform.GetChild(i).gameObject;
            if (classSpawn[4,spawn5.transform.GetChild(i).GetComponent<gameobjImg>().x, spawn5.transform.GetChild(i).GetComponent<gameobjImg>().y].activeSelf == true)
            {
                LstTile.Add(spawn5.transform.GetChild(i).GetComponent<gameobjImg>());
            }
        }

        listID= new List<int>();
        for(int i = 0; i < LstTile.Count/3f; i++ )
        {
            int value = UnityEngine.Random.Range(1, 6);
            if(listID.Count < 10)
            {
                listID.Add(value);
                listID.Add(value);
                listID.Add(value);
            }
            else
            {
                listID.Insert(UnityEngine.Random.Range(1, 10), value);
                listID.Insert(UnityEngine.Random.Range(1, 10), value);
                listID.Insert(UnityEngine.Random.Range(1, 10), value);
            }
            
        }
        //foreach(var x in LstTile)
        //{
        //    Destroy(x.gameObject);
        //}
  
    
        List<int> list = new List<int>();
        List<int> result = new List<int>();
        int max = LstTile.Count;
        for (int i = 1; i <= max; i++)
        {
            list.Add(i);
        }
        //Debug.Log(list.Count);
        //Debug.Log(LstTile.Count);
        //Debug.Log(listID.Count);
        int listcount = list.Count;
        System.Random random = new System.Random();
        for(int i =0; i< listcount; i++)
        {
            int next = list[random.Next(list.Count)];
            LstTile[i].value = listID[i];
            LstTile[i].gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>($"{listID[i].ToString()}");
            list.Remove(next);
            result.Add(next);
        }
        SetTile();
        //Debug.Log(result.Count);
    }


   public void SetTile( )
    {
       
        for(int x = 0; x < 7; x++)
        {
            for(int y =0; y < 10; y++)
            {
                //if(classspawn1[x,y].activeSelf == true)
                //{
                //    Color color = classspawn3[x, y].GetComponent<SpriteRenderer>().color;
                //    classspawn2[x, y].GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, 0.1f);
                //    classspawn2[x+1, y].GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, 0.1f);
                //    classspawn2[x, y+1].GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, 0.1f);
                //    classspawn2[x+1, y+1].GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, 0.1f);
                //    classspawn3[x, y].GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, 0.1f);
                //    classspawn4[x, y].GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, 0.1f);
                //    classspawn4[x + 1, y].GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, 0.1f);
                //    classspawn4[x, y + 1].GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, 0.1f);
                //    classspawn4[x + 1, y + 1].GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, 0.1f);
                //    classspawn5[x, y].GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, 0.1f);
                    
                //}
            }
        }
        for(int i=0; i < 5; i++)
        {
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 11; y++)
                {
                  
                }
            }
        }
   }


    //tinh diem cho tung tile 
}
