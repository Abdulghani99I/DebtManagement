using DebtManagement_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagement_Business
{
    public class clsSettingsUser
    {

        
        enum enMode { AddNew = 1, Update };

        enMode _Mode = enMode.AddNew;

        public int SettingsID { get; set; }
        
        public string UserName { get; set; }

        public string CompanyName { get; set; }

        public string CompanyDescription { get; set; }

        public string PictureData { get; set; }

        public int ConversionValue {  get; set; }


        public clsSettingsUser()
        {
            SettingsID = -1;
            UserName = string.Empty;
            CompanyName = string.Empty;
            CompanyDescription = string.Empty;
            PictureData = string.Empty;
            ConversionValue = -1;

            _Mode = enMode.AddNew;
        }

        public clsSettingsUser(int SettingsID, int UserID, string UserName, string CompanyName, string CompanyDescription, string PictureData, int ConversionValue)
        {
            this.SettingsID = SettingsID;
            this.UserName = UserName;
            this.CompanyName = CompanyName;
            this.CompanyDescription = CompanyDescription;
            this.PictureData = PictureData;
            this.ConversionValue = ConversionValue;

            _Mode = enMode.Update;
        }

        static public clsSettingsUser FindSettingsUser(string UserName)
        {
            int SettingsID = -1, UserID = -1, ConversionValue = -1;

            string CompanyName = "", CompanyDescription = "", PictureData = "";


            bool isFound = clsSettingsUserData.FindSettingsUserByUser(ref SettingsID, ref CompanyName, ref CompanyDescription, ref PictureData, ref ConversionValue);

            if (isFound)
            {
                return new clsSettingsUser(SettingsID, UserID, UserName, CompanyName, CompanyDescription, PictureData, ConversionValue);
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> SaveSettings()
        {
            return await clsSettingsUserData.UpdateSettingsAsync(UserName, CompanyName, CompanyDescription, PictureData, ConversionValue);
        }


        /*
                static public async Task<> GetAllSettingsUserAsync()
                {
                    return await clsSettingsUserData.GetAllSettingsUser();
                }




                private async Task<bool> _AddSettingsUserAsync()
                {
                    int ID = await clsSettingsUserData.AddSettingsUser(this.Name);

                    return ID != -1;
                }

                private async Task<bool> _UpdateSettingsUserAsync()
                {
                    return await clsSettingsUserData.UpdateSettingsUser(this.SettingsUserID, this.Name);
                }

                static private async Task<bool> DeleteSettingsUserAsync(int SettingsUserID)
                {
                    return await clsSettingsUserData.DeleteSettingsUserByID(SettingsUserID);
                }

                public async Task<bool> SaveAsync()
                {
                    bool _result = false;

                    if (_Mode == enMode.AddNew)
                    {
                        _result = await _AddSettingsUserAsync();
                    }
                    else
                    {
                        _result = await _UpdateSettingsUserAsync();
                    }

                    return _result;
                }
        */

    }
}
