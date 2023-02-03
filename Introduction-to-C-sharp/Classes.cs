using System;
namespace Fundamentals
{
    
    // a public class called Tutorial 
    public class Tutorial
    {
        public int TutorialID;
        public string TutorialName;
        protected int TutorialID1;
        protected string TutorialName1;
        public Tutorial()
        {
            TutorialID = 0;
            TutorialName = "Default";
        }
        public void SetTutorial(int pID, string pName)
        {
            TutorialID = pID;
            TutorialName = pName;
        }
        public void SetTutorial(string pName)
        {
            TutorialName = pName;
        }
        public string GetTutorial()
        {
            return TutorialName;
        }
    }
    // A public class called ChildTutorial which is a child class of Tutoriral
    public class ChildTutorial : Tutorial
    {
        public void RenameTutorial(string pNewName)
        {
            TutorialName = pNewName;
        }
    }
    // An abstract class called AbsTutorial 
    abstract class AbsTutorial
    {
        public virtual void Set()
        {

        }
    }
    // a class called AbsChildTutorial which is a child of AbsTutorial 
    class AbsChildTutorial : AbsTutorial
    {
        protected int TutorialID;
        protected string TutorialName;

        public void SetTutorial(int pID, string pName)
        {
            TutorialID = pID;
            TutorialName = pName;
        }
        public string GetTutorial()
        {
            return TutorialName;
        }

    }
    // An interface called FundamentalsInterface 
    interface IFundamentalsInterface
    {
        void SetTutorial(int pID, string pName);
        string GetTutorial();
    }
    // A class called Fundamentals tutorial that extends the interface 
    class FundamentalsTutorial : IFundamentalsInterface
    {
        protected int TutorialID;
        protected string TutorialName;

        public void SetTutorial(int pID, string pName)
        {
            TutorialID = pID;
            TutorialName = pName;
        }
        public string GetTutorial()
        {
            return TutorialName;
        }
    }

    [Serializable]
    public class Tutorial2
    {
        public int  ID;
        public string Name;
    }

}   