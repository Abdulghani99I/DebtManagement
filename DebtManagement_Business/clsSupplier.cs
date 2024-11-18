




using DebtManagement_Data;
using Microsoft.VisualBasic;
using System.Data;

namespace DebtManagement_Business
{
    public class clsSupplier : clsPerson
    {

        enum enMode { AddNew = 1, Update };

        enMode _Mode = enMode.AddNew;
        public int SupplierID { get; set; }
        public decimal BalanceDinar { get; set; }
        public DateTime CreatedAt { get; set; }


        public clsSupplier()
        {
            SupplierID = -1;
            PersonID = -1;
            BalanceDinar = -1;
            CreatedAt = DateTime.MinValue;

            FullName = string.Empty;
            Address = string.Empty;
            Phone = string.Empty;

            _Mode = enMode.AddNew;
        }
        
        public clsSupplier(int SupplierID, int PersonID, Decimal BalanceDinar, DateTime CreatedAt)
        {
            this.SupplierID = SupplierID;
            this.PersonID = PersonID;

            clsPerson InfoPerson = clsPerson.Find(PersonID);

            this.FullName = InfoPerson.FullName;
            this.Address = InfoPerson.Address;
            this.Phone = InfoPerson.Phone;

            this.BalanceDinar = BalanceDinar;
            this.CreatedAt = CreatedAt;

            _Mode = enMode.Update;
        }
        

        static public async Task<DataTable> GetAllSuppliersAsync()
        {
            return await clsSupplierData.GetAllSuppliersAsync();
        }
        
        static public async Task<decimal> GetTotalSuppliersDebt()
        {

            object ? TotalDebt = await clsSupplierData.GetTotalSuppliersDebt();

            if (!(TotalDebt is DBNull))
                return Convert.ToDecimal(TotalDebt);
            else
                return 0;
        }
        
        static public async Task<decimal> GetTotalSuppliersPayments()
        {

            object ? TotalPayments = await clsSupplierData.GetTotalSuppliersPayments();

            if (!(TotalPayments is DBNull))
                return Convert.ToDecimal(TotalPayments);
            else
                return 0;

        }

        static public async Task<DataTable> GetSupplierDebtBySupplierIDAsync(int SupplierID)
        {
            return await clsSupplierData.GetSupplierDebtBySupplierIDAsync(SupplierID);
        }

        static public async Task<DataTable> GetSupplierPaymentsBySupplierIDAsync(int SupplierID)
        {
            return await clsSupplierData.GetSupplierPaymentsBySupplierIDAsync(SupplierID);
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

        private async Task<bool> _AddSupplierAsync()
        {
            int ID = await clsSupplierData.AddSupplierAsync(this.FullName, this.Phone, this.Address);

            return ID != -1;
        }

        static public clsSupplier Find(int SupplierID)
        {
            int _PersonID = -1;
            Decimal _BalanceDinar = 0;
            DateTime _CreatedAt = DateTime.MinValue;

            bool isFound = clsSupplierData.FindSupplierByID(SupplierID, ref _PersonID, ref _BalanceDinar, ref _CreatedAt);

            if (isFound)
            {
                return new clsSupplier(SupplierID, _PersonID, _BalanceDinar, _CreatedAt);
            }
            else
            {
                return new clsSupplier();
            }
        }


        
        private async Task<bool> _UpdateSupplierAsync()
        {
            return await clsSupplierData.UpdateSupplierAsync(this.SupplierID, this.FullName, this.Phone, this.Address);
        }


        static public async Task<bool> DeleteSupplierAsync(int SupplierID)
        {
            return await clsSupplierData.DeleteSupplierByIDAsync(SupplierID);
        }
        
        static async public Task<bool> ResetSupplierDebtAndPaymentsAsync(int SupplierID)
        {
            return await clsSupplierData.ResetSupplierDebtAndPaymentsAsync(SupplierID);
        }

        static async public Task<bool> DeleteSupplierDebtAsync(int DebtMenuID)
        {
            return await clsSupplierData.DeleteSupplierDebtAsync(DebtMenuID);
        }



        static public async Task<int> AddSupplierDebtMenuAsync(int SupplierID, string MenuName, decimal Amount)
        {
            return await clsSupplierData.AddSupplierDebtMenuAsync(SupplierID, MenuName, Amount);
        }


        static public async Task<bool> UpdateSupplierDebtAsync(int DebtMenuID, string MenuName, decimal Amount)
        {
            return await clsSupplierData.UpdateSupplierDebtAsync(DebtMenuID, MenuName, Amount);
        }

        static public bool FindSupplierDebtMenuAsync(int DebtMenuID, ref string MenuName, ref decimal Amount)
        {
            return clsSupplierData.FindSupplierDebtMenuByDebtMenuID(DebtMenuID, ref MenuName, ref Amount);
        }

        static public async Task<bool> DeleteSupplierPaymentAsync(int PaymentID)
        {
            return await clsSupplierData.DeleteSupplierPaymentAsync(PaymentID);
        }

        static public async Task<int> AddSupplierPaymentAsync(int SupplierID, decimal Amount)
        {
            return await clsSupplierData.AddSupplierPaymentAsync(SupplierID, Amount);
        }
    
        static public bool FindSupplierPaymentAsync(int PaymentID, ref decimal Amount)
        {
            return clsSupplierData.FindSupplierPaymentAsync(PaymentID, ref Amount);
        }


        static public async Task<bool> UpdateSupplierPaymentAsync(int PaymentID, decimal Amount)
        {
            return await clsSupplierData.UpdateSupplierPaymentAsync(PaymentID, Amount);
        }


    }

}
