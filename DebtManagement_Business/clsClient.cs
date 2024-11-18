




using DebtManagement_Data;
using Microsoft.VisualBasic;
using System.Data;

namespace DebtManagement_Business
{
    public class clsClient : clsPerson
    {

        enum enMode { AddNew = 1, Update };

        enMode _Mode = enMode.AddNew;
        public int ClientID { get; set; }
        public decimal BalanceDinar { get; set; }
        public DateTime CreatedAt { get; set; }


        public clsClient()
        {
            ClientID = -1;
            PersonID = -1;
            BalanceDinar = -1;
            CreatedAt = DateTime.MinValue;

            FullName = string.Empty;
            Address = string.Empty;
            Phone = string.Empty;

            _Mode = enMode.AddNew;
        }
        
        public clsClient(int ClientID, int PersonID, Decimal BalanceDinar, DateTime CreatedAt)
        {
            this.ClientID = ClientID;
            this.PersonID = PersonID;

            clsPerson InfoPerson = clsPerson.Find(PersonID);

            this.FullName = InfoPerson.FullName;
            this.Address = InfoPerson.Address;
            this.Phone = InfoPerson.Phone;

            this.BalanceDinar = BalanceDinar;
            this.CreatedAt = CreatedAt;

            _Mode = enMode.Update;
        }
        

        static public async Task<DataTable> GetAllClientsAsync()
        {
            return await clsClientData.GetAllClientsAsync();
        }
        
        static public async Task<decimal> GetTotalClientsDebt()
        {
            object ? TotalDebt = await clsClientData.GetTotalClientsDebtAsync();


            if (!(TotalDebt is DBNull))
                return Convert.ToDecimal(TotalDebt);
            else
                return 0;
        }
          
        static public async Task<decimal> GetTotalClientsPayments()
        {
            object ? TotalPayments = await clsClientData.GetTotalClientsPaymentsAsync();

            if (!(TotalPayments is DBNull))
                return Convert.ToDecimal(TotalPayments);
            else
                return 0;
        
        }

        static public async Task<DataTable> GetClientDebtByClientIDAsync(int ClientID)
        {
            return await clsClientData.GetClientDebtByClientIDAsync(ClientID);
        }

        static public async Task<DataTable> GetClientPaymentsByClientIDAsync(int ClientID)
        {
            return await clsClientData.GetClientPaymentsByClientIDAsync(ClientID);
        }

        public async Task<bool> SaveAsync()
        {
            bool _result = false;

            if (_Mode == enMode.AddNew)
            {
                _result = await _AddClientAsync();
            }
            else
            {
                _result = await _UpdateClientAsync();
            }

            return _result;
        }

        private async Task<bool> _AddClientAsync()
        {
            int ID = await clsClientData.AddClientAsync(this.FullName, this.Phone, this.Address);

            return ID != -1;
        }

        static public clsClient Find(int ClientID)
        {
            int _PersonID = -1;
            Decimal _BalanceDinar = 0;
            DateTime _CreatedAt = DateTime.MinValue;

            bool isFound = clsClientData.FindClientByID(ClientID, ref _PersonID, ref _BalanceDinar, ref _CreatedAt);

            if (isFound)
            {
                return new clsClient(ClientID, _PersonID, _BalanceDinar, _CreatedAt);
            }
            else
            {
                return new clsClient();
            }
        }


        
        private async Task<bool> _UpdateClientAsync()
        {
            return await clsClientData.UpdateClientAsync(this.ClientID, this.FullName, this.Phone, this.Address);
        }


        static public async Task<bool> DeleteClientAsync(int ClientID)
        {
            return await clsClientData.DeleteClientByIDAsync(ClientID);
        }
        
        static async public Task<bool> ResetClientDebtAndPaymentsAsync(int ClientID)
        {
            return await clsClientData.ResetClientDebtAndPaymentsAsync(ClientID);
        }

        static async public Task<bool> DeleteClientDebtAsync(int DebtMenuID)
        {
            return await clsClientData.DeleteClientDebtAsync(DebtMenuID);
        }



        static public async Task<int> AddClientDebtMenuAsync(int ClientID, string MenuName, decimal Amount)
        {
            return await clsClientData.AddClientDebtMenuAsync(ClientID, MenuName, Amount);
        }


        static public async Task<bool> UpdateClientDebtAsync(int DebtMenuID, string MenuName, decimal Amount)
        {
            return await clsClientData.UpdateClientDebtAsync(DebtMenuID, MenuName, Amount);
        }

        static public bool FindClientDebtMenuAsync(int DebtMenuID, ref string MenuName, ref decimal Amount)
        {
            return clsClientData.FindClientDebtMenuByDebtMenuID(DebtMenuID, ref MenuName, ref Amount);
        }

        static public async Task<bool> DeleteClientPaymentAsync(int PaymentID)
        {
            return await clsClientData.DeleteClientPaymentAsync(PaymentID);
        }

        static public async Task<int> AddClientPaymentAsync(int ClientID, decimal Amount)
        {
            return await clsClientData.AddClientPaymentAsync(ClientID, Amount);
        }
    
        static public bool FindClientPaymentAsync(int PaymentID, ref decimal Amount)
        {
            return clsClientData.FindClientPaymentAsync(PaymentID, ref Amount);
        }


        static public async Task<bool> UpdateClientPaymentAsync(int PaymentID, decimal Amount)
        {
            return await clsClientData.UpdateClientPaymentAsync(PaymentID, Amount);
        }


    }

}
