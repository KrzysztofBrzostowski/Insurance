using System.ComponentModel;

namespace Insurance.Models
{
    public class Customer : Base, IDataErrorInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string m_pesel;
        public string Pesel {
            get { return m_pesel; }
            set {
                //if (value.Length == 11) 
                    m_pesel = value;
            }
        }

        public string Error { get { return string.Empty; } } //string.Empty; //throw new System.NotImplementedException();

        public string this[string columnName] { 
            get
            {
                if (columnName=="FirstName")
                {
                    if (string.IsNullOrEmpty(FirstName))
                    {
                        return "Imie jest obowiazkowe";
                    }
                }
                if (columnName == "Pesel")
                {
                    if (string.IsNullOrEmpty(Pesel))
                    {
                        return "Pole Pesel jest obowiazkowe";
                    }
                    if (Pesel.Length!=11)
                    {
                        return "Pole Pesel powinno miec 11 znakow";
                    }
                }

                return null;
            }
        }  //throw new System.NotImplementedException();
    }
}
