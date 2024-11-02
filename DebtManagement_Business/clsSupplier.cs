




using DebtManagement_Data;
using Microsoft.VisualBasic;
using System.Data;

namespace DebtManagement_Business
{
    public class clsSupplier
    {

        enum enMode { AddNew = 1, Update };

        enMode _Mode = enMode.AddNew;
        public int SupplierID { get; set; }
        public int PersonID { get; set; }
        public decimal BalanceDinar { get; set; }
        public DateTime CreatedAt { get; set; }

        // public clsPerson InfoPerson {get; set}



        clsSupplier()
        {
            SupplierID = -1;
            PersonID = -1;
            BalanceDinar = -1;
            CreatedAt = DateTime.MinValue;
            // InfoPerson = new clsPerson();

            _Mode = enMode.AddNew;
        }
        /*
        public clsSupplier(int SupplierID, string name)
        {
            SupplierID = SupplierID;
            Name = name;

            _Mode = enMode.Update;
        }
        */

        static public async Task<DataTable> GetAllSuppliersAsync()
        {
            return await clsSupplierData.GetAllSuppliersAsync();
        }

        /*
        static public clsSupplier FindSupplier(int SupplierID)
        {
            string name = "";

            bool isFound = clsSupplierData.FindSupplierByID(SupplierID, ref name);

            if (isFound)
            {
                return new clsSupplier(SupplierID, name);
            }
            else
            {
                return null;
            }
        }


        private async Task<bool> _AddSupplierAsync()
        {
            int ID = await clsSupplierData.AddSupplier(this.Name);

            return ID != -1;
        }

        private async Task<bool> _UpdateSupplierAsync()
        {
            return await clsSupplierData.UpdateSupplier(this.SupplierID, this.Name);
        }

        static private async Task<bool> DeleteSupplierAsync(int SupplierID)
        {
            return await clsSupplierData.DeleteSupplierByID(SupplierID);
        }

        public async Task<bool> SaveAsync()
        {
            bool _result = false;

            if (_Mode == enMode.AddNew)
            {
                _result = await _AddSupplierAsync();
            }
            else
            {
                _result = await _UpdateSupplierAsync();
            }

            return _result;
        }
        */
    }
}
