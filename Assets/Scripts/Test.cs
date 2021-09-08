using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Linq;

public class Test : MonoBehaviour
{
    public Transform[] path;
    // Start is called before the first frame update
    void Start()
    {
        Text tx = transform.GetComponent<Text>();
        //tx.DOText("送到发送到",2).SetEase(Ease.Linear).OnComplete(()=> {
        //    Debug.Log("CCCCCCCCCCCCCCCCC");
        //});

        //tx.DOText("送到发送到", 2).SetEase(Ease.Linear).OnComplete(CompleteCall);
        var posList = path.Select(u => u.position).ToArray();
        Debug.Log("CCCCCCCCCCCCCCCCC   "+ posList.Length);
        transform.DOPath(posList, 5, PathType.CatmullRom, PathMode.Full3D, 10, Color.red);
        
    }
    void CompleteCall()
    {
        Debug.Log("CCCCCCCCCCCCCCCCC");
    }


    // Update is called once per frame
    void Update()
    {
        //transform.DOLocalMove(Vector3.left, 2);
        //transform.DOPunchPosition()
    }
}
