using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanOOP
{
    class PlayStore : Google
    {
        static String[] available = { "PUBG","VLC","MX","Adobe","GPay","PayTm","Canva" };
        String[] download = new String[10];
        public void install(String user)
        {
            for (int index=0;index<available.Length;index++)
            {
                if(available[index] == user)
                {
                    for (int pos=0;pos<download.Length;pos++)
                    {
                        if (download[pos]==null)
                        {
                            download[pos] = user;
                            Console.WriteLine(user + " app is installed in your device");
                            return;
                        }
                    }
                    Console.WriteLine("Insufficient space to install " + user);
                }
            }
            Console.WriteLine(user + " is not in PlayStore");
        }
        public void myApps()
        {
            Console.WriteLine(Name + " from " + email + " has following apps installed");
            Array.ForEach(download, val => Console.WriteLine(val));
        }
    }
    class youtube:Google
    {
        bool isOkay=false;
        String[] liked = new string[10];
        String[] playlist = { "Rahaman 90's","Yuvan Dopes","Ilayaraja melodies","Unni menon songs"};
        
        public void isValid()
        {
            Console.WriteLine("Enter the username ");
            String em = Console.ReadLine();
            Console.WriteLine("Enter the password ");
            String ps = Console.ReadLine();
            if (em==email&&ps==password)
            {
                isOkay=true;
            }
            else
            {
                isOkay = false;
            }
        }

        public void viewMyList()
        {
            if (isOkay)
            {
                Console.WriteLine(email + " viewing their playlist as ");
                Array.ForEach(playlist, val => Console.WriteLine(val));
            }
            else
            {
                Console.WriteLine("invalid user");
            }
        }
        public void addToLiked(String user)
        {
            if (isOkay)
            {
                for (int index = 0; index < liked.Length; index++)
                {
                    if (liked[index] == null)
                    {
                        liked[index] = user;
                        Console.WriteLine(user + " was added to liked viedo's of " + Name);
                        return;
                    }
                }
                Console.WriteLine(user + " can;t add to liked video's");
            }
            else
            {
                Console.WriteLine("Invalid user");
            }
        }
    }
    class Google
    {
        public String email { set; get; }
        public String password { set; get; }
        public String Name { set; get; }
        public long Contact { set; get; }
    }
}
