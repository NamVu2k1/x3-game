using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameobjImg : MonoBehaviour
{
    public bool onClick;
    public int ClassSpawn;
    public int x, y;
    public int Point;
    public int value;
    public void OnMouseDown()
    {
        onClick = true;
        Controller.Instance.ButtonClick(value, gameObject);
        SpawnTile.Instance.SetTile();
    }
}
