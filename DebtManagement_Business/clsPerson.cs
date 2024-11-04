using DebtManagement_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagement_Business
{
    public class clsPerson
    {

        enum enMode { AddNew = 1, Update };

        enMode _Mode = enMode.AddNew;
        public int PersonID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }



        public clsPerson()
        {
            PersonID = -1;
            FullName = string.Empty;
            Address = string.Empty;
            Phone = string.Empty;


            _Mode = enMode.AddNew;
        }

        public clsPerson(int PersonID, string FullName, string Phone, string Address)
        {
            this.PersonID = PersonID;
            this.FullName = FullName;
            this.Address = Address;
            this.Phone = Phone;


            _Mode = enMode.Update;
        }

        static protected clsPerson Find(int PersonID)
        {

            string FullName = string.Empty,
                   Phone = string.Empty,
                   Address = string.Empty;


            bool isFound = clsPersonData.FindPersonByID(PersonID, ref FullName, ref Phone, ref Address);

            if (isFound)
            {
                return new clsPerson(PersonID, FullName, Phone, Address);
            }
            else
            {
                return new clsPerson();
            }
        }

        /*
        static public async Task<DataTable> GetAllStadardAsync()
        {
            return await clsPersonData.GetAllStadard();
        }




        private async Task<bool> _AddPersonAsync()
        {
            int ID = await clsPersonData.AddPerson(this.Name);

            return ID != -1;
        }

        private async Task<bool> _UpdatePersonAsync()
        {
            return await clsPersonData.UpdatePerson(this.PersonID, this.Name);
        }

        static private async Task<bool> DeletePersonAsync(int PersonID)
        {
            return await clsPersonData.DeletePersonByID(PersonID);
        }

        public async Task<bool> SaveAsync()
        {
            bool _result = false;

            if (_Mode == enMode.AddNew)
            {
                _result = await _AddPersonAsync();
            }
            else
            {
                _result = await _UpdatePersonAsync();
            }

            return _result;
        }
        */



    }
}
