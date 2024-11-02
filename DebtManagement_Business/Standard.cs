using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagement
{
    internal class Standard
    {
        /*
        enum enMode { AddNew = 1, Update };

        enMode _Mode = enMode.AddNew;
        public int StandardID { get; set; }
        public string Name { get; set; }



        clsStandard()
        {
            StandardID = -1;
            Name = string.Empty;


            _Mode = enMode.AddNew;
        }

        public clsStandard(int StandardID, string name)
        {
            StandardID = StandardID;
            Name = name;

            _Mode = enMode.Update;
        }


        static public async Task<DataTable> GetAllStadardAsync()
        {
            return await clsStandardData.GetAllStadard();
        }


        static public clsStandard FindStandard(int StandardID)
        {
            string name = "";

            bool isFound = clsStandardData.FindStandardByID(StandardID, ref name);

            if (isFound)
            {
                return new clsStandard(StandardID, name);
            }
            else
            {
                return null;
            }
        }


        private async Task<bool> _AddStandardAsync()
        {
            int ID = await clsStandardData.AddStandard(this.Name);

            return ID != -1;
        }

        private async Task<bool> _UpdateStandardAsync()
        {
            return await clsStandardData.UpdateStandard(this.StandardID, this.Name);
        }

        static private async Task<bool> DeleteStandardAsync(int StandardID)
        {
            return await clsStandardData.DeleteStandardByID(StandardID);
        }

        public async Task<bool> SaveAsync()
        {
            bool _result = false;

            if (_Mode == enMode.AddNew)
            {
                _result = await _AddStandardAsync();
            }
            else
            {
                _result = await _UpdateStandardAsync();
            }

            return _result;
        }
        */

    }
}
