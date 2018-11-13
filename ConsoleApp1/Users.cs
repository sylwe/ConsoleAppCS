using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Users
    {
        //Stan
        protected String userName = "Jacek";
        protected String userSurename = "Placek";
        private String name;
        private String surename;
        //List<String> name;
        //List<String> surename;


        //Zachowania
        public Users()
        {

        }

        public Users(String name, String surename)
        {
            this.name = name;
            this.surename = surename;
        }

        public String getName()
        {
            return name;            
        }
        public String getSurename()
        {
            return surename;
        }

    }
}
