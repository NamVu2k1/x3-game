using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class Controller : MonoBehaviour
{
    public List<Transform> Trans;
    public static Controller Instance;

   
    public List<int> Lst;
    public List<GameObject> lstSpawn;



    public GameObject[,] tile;
    private void Awake()
    {
        tile = new GameObject[7, 10];
        Instance = this;
    }
    void Start()
    {
      
    }
    public void ButtonClick(int value, GameObject gameObj)
    {
        if(Lst.Contains(value) == false)
        {
            Lst.Add(value);
            lstSpawn.Add(gameObj);
        }
        else
        {
            Lst.Insert( Lst.IndexOf(value), value);
            lstSpawn.Insert(Lst.IndexOf(value), gameObj);
        }
        for(int i=0; i < Lst.Count; i++)
        {
            if( i + 2 < Lst.Count)
            {
                if (Lst[i] == Lst[i + 1] && Lst[i] == Lst[i + 2])
                {
                    Lst.Remove(Lst[i]);
                    Lst.Remove(Lst[i]);
                    Lst.Remove(Lst[i]);
                    var des = lstSpawn[i];
                    lstSpawn.Remove(lstSpawn[i]);
                    Destroy(des);
                    var des1 = lstSpawn[i];
                    lstSpawn.Remove(lstSpawn[i]);
                    Destroy(des1);
                    var des2 = lstSpawn[i];
                    lstSpawn.Remove(lstSpawn[i]);
                    Destroy(des2);
                }
            }
           
        }
        for(int i =0; i < lstSpawn.Count;i++)
        {
            //lstSpawn[i].transform.position = Trans[i].position;
            
            lstSpawn[i].transform.DOMove(Trans[i].position, 0.8f);
           // lstSpawn[i].transform.DOMove(Trans[i].position,0.8f);

        }
        if(Lst.Count == 8)
        {
            Debug.Log("lose");
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
