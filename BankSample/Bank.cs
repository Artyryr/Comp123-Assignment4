using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace BankSample
{
    [Serializable()]
    public class Bank
    {
        public static List<Branch> branches = new List<Branch>() { };
        public string Name { get; set; }
        List<Branch> Branches { get; set; }
        public Bank(string name = "TD-Scotia Bank")
        {
            Name = name;
            Branches = branches;
        }
        public Bank() {  }
        public static void AddBranch(Branch branch)
        {
            branch.Customers = new List<Customer>() { };
            branches.Add(branch);
        }
        public static void DeleteBranch(Branch branch)
        {
            branches.Remove(branch);
        }
        public static void UpdateBranch(Branch branch, Address address)
        {
            for (int i = 0; i < branches.Count(); i++)
            {
                if (branches[i] == branch)
                {
                    branches[i].Address = address;
                }
            }
        }
        public static List<Branch> GetBranches()
        {
            return branches;
        }
        public static void WriteToXML()
        {
            using (TextWriter writer = new StreamWriter("Bank.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Branch>));
                serializer.Serialize(writer, Bank.GetBranches());
            }
        }
        public static void ReadFromXML()
        {
            using (TextReader reader = new StreamReader("Bank.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Branch>));
                branches = (List<Branch>)serializer.Deserialize(reader);
            }
        }

        //public static Bank ReadFromXML()
        //{
        //    using (TextReader reader = new StreamReader("Bank.xml"))
        //    {
        //        XmlSerializer serializer = new XmlSerializer(typeof(Bank));
        //        return (Bank)serializer.Deserialize(reader);
        //    }
        //}
        //public static void WriteToXML(Bank bank)
        //{
        //    using (TextWriter writer = new StreamWriter("Bank.xml"))
        //    {
        //        XmlSerializer serializer = new XmlSerializer(typeof(Bank));
        //        serializer.Serialize(writer, bank);
        //    }
        //}




        //------------------





        //private static List<Branch> branches = new List<Branch>(){};
        ////public static Bank bank = new Bank();

        //public string Name { get; set; }
        //public Bank(string name = "TD-Scotia Bank") {
        //    Name = name;
        //}
        //public Bank() { }
        //public static void AddBranch(Branch branch)
        //{
        //    branches.Add(branch);
        //}
        //public static void DeleteBranch(Branch branch)
        //{
        //    branches.Remove(branch);
        //}
        //public static void UpdateBranch(Branch branch, Address address)
        //{
        //    for (int i = 0; i < branches.Count(); i++)
        //    {
        //        if (branches[i] == branch)
        //        {
        //            branches[i].Address = address;
        //        }
        //    }
        //}
        ////public static Branch OpenBranch(string branchName)
        ////{
        ////    for (int i = 0; i < branches.Count(); i++)
        ////    {
        ////        if (branches[i].Address.ToString() == branchName)
        ////        {
        ////            return branches[i];
        ////        }
        ////        else { return; }
        ////    }
        ////}
        //public static List<Branch> GetBranches()
        //{
        //    return branches;
        //}

        //public static void WriteToXML()
        //{
        //    using (TextWriter writer = new StreamWriter("Bank.xml"))
        //    {
        //        XmlSerializer serializer = new XmlSerializer(typeof(List<Branch>));
        //        serializer.Serialize(writer, branches);
        //    }
        //}

        //public static void ReadFromXML()
        //{
        //    using (TextReader reader = new StreamReader("Bank.xml"))
        //    {
        //        XmlSerializer serializer = new XmlSerializer(typeof(List<Branch>));
        //        branches = (List<Branch>)serializer.Deserialize(reader);
        //    }
        //}
        ////public void AddBranch(Branch branch)
        ////{
        ////    branches.Add(branch);
        ////}
        ////public void DeleteBranch(Branch branch)
        ////{
        ////    branches.Remove(branch);
        ////}
        ////public void UpdateBranch(Branch branch, Address address)
        ////{
        ////    for (int i = 0; i < branches.Count(); i++)
        ////    {
        ////        if (branches[i] == branch)
        ////        {
        ////            branches[i].Address = address;
        ////        }
        ////    }
        ////}
        ////public static List<Branch> GetBranches()
        ////{
        ////    return branches;
        ////}
        ////public static void WriteToXML(Bank bank)
        ////{
        ////    using (TextWriter writer = new StreamWriter("Bank.xml"))
        ////    {
        ////        XmlSerializer serializer = new XmlSerializer(typeof(Bank));
        ////        serializer.Serialize(writer, bank);
        ////    }
        ////}

        ////public Bank ReadFromXML()
        ////{
        ////    using (TextReader reader = new StreamReader("Bank.xml"))
        ////    {
        ////        XmlSerializer serializer = new XmlSerializer(typeof(Bank));
        ////        return (Bank)serializer.Deserialize(reader);
        ////    }
        ////}
    }
}
