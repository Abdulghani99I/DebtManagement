




using DebtManagement_Data;
using System.Data;

namespace DebtManagement_Business
{
    public class clsUser
    {
       
        enum enMode { AddNew = 1, Update };

        enMode _Mode = enMode.AddNew;
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsManager { get; set; }



        public clsUser()
        { 
            UserID = -1;
            FullName = string.Empty;
            UserName = string.Empty;
            Password = string.Empty;
            IsManager = false;

            _Mode = enMode.AddNew;
        }

        public clsUser(int UserID, string FullName, string UserName, string Password, bool IsManager)
        {
            this.UserID = UserID;

            this.FullName = FullName;
            this.UserName = UserName;
            this.Password = Password;
            this.IsManager = IsManager;

            _Mode = enMode.Update;
        }
        static public async Task<DataTable> GetAllUserAsync()
        {
            return await clsUserData.GetAllUsersAsync();
        }


        static public clsUser FindUser(int UserID)
        {
            string FullName = "", UserName = "", Password = "";
            bool isManager = false;

            bool isFound = clsUserData.FindUserByID(UserID, ref FullName, ref UserName, ref Password, ref isManager);

            if (isFound)
            {
                return new clsUser(UserID, FullName, UserName, Password, isManager);
            }
            else
            {
                return null;
            }
        }

        
        static public clsUser FindUser(string Userame)
        {
            int UserID = -1;
            string FullName = "", Password = "";
            bool isManager = false;

            bool isFound = clsUserData.FindUserByUserName(Userame, ref UserID, ref FullName, ref Password, ref isManager);

            if (isFound)
            {
                return new clsUser(UserID, FullName, Userame, Password, isManager);
            }
            else
            {
                return null;
            }
        }

        private async Task<bool> _AddUserAsync()
        {
            int ID = await clsUserData.AddUserAsync(this.FullName, this.UserName, this.Password, this.IsManager);

            return ID != -1;
        }




        private async Task<bool> _UpdateUserAsync()
        {
            return await clsUserData.UpdateUserAsync(this.UserID, this.FullName, this.UserName, this.Password, this.IsManager);
        }


        public async Task<bool> SaveAsync()
        {
            bool _result = false;

            if (_Mode == enMode.AddNew)
            {
                _result = await _AddUserAsync();
            }
            else
            {
                _result = await _UpdateUserAsync();
            }

            return _result;
        }


       static public async Task<bool> DeleteUserAsync(int UserID)
       {
           return await clsUserData.DeleteUserByIDAsync(UserID);
       }


    }
}
