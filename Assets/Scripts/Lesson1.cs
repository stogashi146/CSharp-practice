using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Person p = new Person();
        p.firstname = "太郎";
        p.lastname = "山田";
        //Debug.Log(p.GetFullName());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Person
{
    public string firstname;
    public string lastname;

    public string GetFullName(string fn, string ln)
    {
        return this.lastname + this.firstname;
    }
    public Person() { }
}