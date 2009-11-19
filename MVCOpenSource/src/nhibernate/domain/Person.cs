namespace domain
{
    using System;

    [Serializable]
    public class Person : EntityBase
    {
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        public virtual Address Address { get; set; }

        public override string ToString()
        {
            return (!string.IsNullOrEmpty(MiddleName))
                ? string.Format("{0} {1} {2}", FirstName, MiddleName, LastName) :
                string.Format("{0} {1}", FirstName, LastName);
        }
    }
}