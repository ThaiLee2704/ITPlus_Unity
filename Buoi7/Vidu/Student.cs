using System;
using System.Collections;
using System.Collections.Generic;

public class Student
{
    public readonly int id;

    private string name;
    public string _name
    {
        get { return name; }
        private set { if (validName(value)) name = value; }
    }

    private string _class;
    public string __class
    {
        get { return _class; }
        private set { _class = value; }
    }

    private GENDER gender;

    public GENDER _gender
    {
        get { return gender; }
        private set { gender = value; }
    }

    private float score;
    public float _score
    {
        get { return score; }
        private set { score = value; }
    }

    public Dictionary<SUBJECT, float> subScores = new Dictionary<SUBJECT, float>();
    public enum SUBJECT
    {
        MATH,
        TRIET
    }

    public Student()
    {
        this.id = 0;
        this.name = "A";
        this._class = "1A";
        this.score = 0;
        this.gender = GENDER.MALE;
    }

    public Student(int id, string name, string _class, float score, GENDER gender = GENDER.MALE)
    {
        this.id = id;
        this.name = name;
        this._class = _class;
        this.score = score;
        this.gender = gender;
    }

    bool validName(string name)
    {
        if (name.Length <= 3)
            return false;
        return true;
    }

    public enum GENDER
    {
        MALE,
        FEMALE
    }

    public void PrintInfo()
    {
        Console.WriteLine(String.Format("id: {0} -- name: {1} -- class: {2}" +
                    "--gender: {3} -- score: {4}", this.id, this._name, this.__class, this._gender, this.score));
    }

    public void SetName(string newName)
    {
        this.name = newName;
    }
    public void SetClass(string newClass)
    {
        this._class = newClass;
    }
    //public void SetScore(float newScore)
    //{
    //    this.score = newScore;
    //}
    public void SetScore(List<float> scores, float score = -1)
    {
        if (score != -1)
        {
            this.score = score;
            return;
        }
        float sum = 0;

        foreach (float i in scores)
        {
            sum += i;
        }

        this.score = sum / scores.Count;
        if (this.score < 6)
            Console.WriteLine("TBC nho hon 6");
    }

    public void SetGender(GENDER newGender)
    {
        this.gender = newGender;
    }

}


