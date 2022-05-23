using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Classes
{
    
    public class User
    {
        private int userID;
        private string userName;
        private string passWord;
        private int age;
        private int weight;
        private int height;
        private string sex;
        private string activityLevel;

        // getters
        public int UserID
        {
            get { return userID; }
        }
        public string getName
        {
            get { return userName; }
        }

        public int getHeight
        {
            get { return height; }
        }

        public string getPassword
        {
            get { return passWord; }
        }

        public string getActivityLevel
        {
            get { return activityLevel; }
        }

        public string getSex
        {
            get { return sex; }
        }

        public int getAge
        {
            get { return age; }
        }

        public int getWeight
        {
            get { return weight; }
        }



        // setters
        public int setUserID
        {
            set { userID = value; }
        }

        public string setUsername
        {
            set { userName = value; }
        }

        public string setPassword
        {
            set { passWord = value; }
        }
        public int setAge
        {
            set { age = value; }
        }

        public int setWeight
        {
            set { weight = value; }
        }

        public string setSex
        {
            set { sex = value; }
        }

        public string setActivityLevel
        {
            set { activityLevel = value; }
        }



        //constructors
        public User(string userName, string passWord)
        {
            this.userName = userName;
            this.passWord = passWord;
        }

        public User(string userName, string passWord, int age, int weight)
        {
            this.userName = userName;
            this.passWord = passWord;
            this.age = age;
            this.weight = weight;
        }

        public User(string userName, string passWord, int age, int weight, string sex)
        {
            this.userName = userName;
            this.passWord = passWord;
            this.age = age;
            this.weight = weight;
            this.sex = sex;
        }

        public User(string userName, string passWord, int age, int weight, string sex, string activityLevel)
        {
            this.userName = userName;
            this.passWord = passWord;
            this.age = age;
            this.weight = weight;
            this.sex = sex;
            this.activityLevel = activityLevel;
        }

    }
}
