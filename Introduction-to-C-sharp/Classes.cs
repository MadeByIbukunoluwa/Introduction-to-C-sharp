using System;

namespace Fundamentals {

    public class Tutorial{
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
        public string GetTutorial()
        {
            return TutorialName;
        }
    }
    public class childTutorial : Tutorial
    {
        public void RenameTutorial(string pNewName)
        {

        }
    }
}