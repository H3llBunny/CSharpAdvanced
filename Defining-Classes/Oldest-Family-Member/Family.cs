﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class Family
    {
        private List<Person> membersList;

        public List<Person> MembersList
        {
            get { return membersList; }
            set { membersList = value; }
        }

        public Family()
        {
            this.MembersList = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.MembersList.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.membersList.OrderByDescending(p => p.Age).FirstOrDefault();
        }
    }
}
