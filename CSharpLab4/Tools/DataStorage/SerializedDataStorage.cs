using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CSharpLab4.Models;
using CSharpLab4.Tools.Managers;

namespace CSharpLab4.Tools.DataStorage
{
    internal class SerializedDataStorage:IDataStorage
    {
        private readonly List<Person> _users;
      

        internal SerializedDataStorage()
        {
            try
            {
                _users = SerializationManager.Deserialize<List<Person>>(FileFolderHelper.StorageFilePath);
            }
            catch (FileNotFoundException)
            {
                _users = new List<Person>();
            }
        }

        public void ChangeUser(Person changedPerson)
        {
            Guid g = _users.Find(  
            delegate (Person p)
            {
                return p.Guid == changedPerson.Guid;
            }
            ).Guid;
            DeleteUser(g);
            AddUser(changedPerson);
        }

        public Person GetUser(Guid guid)
        {
            return _users.Find( 
            delegate (Person p)
            {
                return p.Guid == guid;
            }
            );
        }

        public void AddUser(Person user)
        {
            _users.Add(user);
            SaveChanges();
        }

        public void DeleteUser(Guid guid)
        {
            foreach (Person user in _users)
            {
                if (user.Guid == guid)
                {
                    _users.Remove(user);
                    break;
                }
            }
        }

        public List<Person> UsersList
        {
            get { return _users.ToList(); }
        }

        private void SaveChanges()
        {
            SerializationManager.Serialize(_users, FileFolderHelper.StorageFilePath);
        }

        public void AddUsers()
        {
            
            _users.Add(new Person("ABCDE", "KLDNF", "ABCDE@gmail.com", new DateTime(2001, 12, 10)));
            _users.Add(new Person("AFHKL", "LDBDS", "LDBDS@gmail.com", new DateTime(2002, 5, 19)));
            _users.Add(new Person("BACDE", "MFJSF", "BACDE@gmail.com", new DateTime(2003, 1, 1)));
            _users.Add(new Person("BCKLM", "NOSJW", "NOSJW@gmail.com", new DateTime(2016, 3, 10)));
            _users.Add(new Person("CDEFHK", "POFND", "CDEFHK@gmail.com", DateTime.Now.Date));
            _users.Add(new Person("CHDLFD", "OPNSI", "OPNSI@gmail.com", new DateTime(2001, 12, 10)));
            _users.Add(new Person("DLKNSL", "RLDYW", "DLKNSL@gmail.com", new DateTime(1990, 5, 19)));
            _users.Add(new Person("DLFMFD", "QUFMD", "QUFMD@gmail.com", new DateTime(2012, 1, 1)));
            _users.Add(new Person("EFKSKF", "VKSKF", "EFKSKF@gmail.com", new DateTime(2019, 3, 10)));
            _users.Add(new Person("EKFJOS", "UFMSM", "UFMSM@gmail.com", DateTime.Now.Date));

            SaveChanges();
        }


    }
}

