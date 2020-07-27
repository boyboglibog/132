﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneBGSConsole
{
    public interface IDataProvider
    {

        #region View
        List<UserType> GetUserType();
        List<EnvironmentalConcern> GetEnvironmentalConcern();
        List<UpdatedStatus> GetUpdatedStatus();
        List<CaseReport> GetCaseReport();

        #endregion

        #region Insert
        List<UserType> InsertUserType(int UserTypeID, string Description);
        List<EnvironmentalConcern> InsertEnvironmentalConcern(int EnvironmentalConcernID, string Description);
        List<UpdatedStatus> InsertUpdatedStatus(int UpdatedStatusID, string Description);

        List<CaseReport> InsertCaseReport(int UserInformationID, int EnvironmentalConcernID, int XCoordinates, int YCoordinates, string CaseReportPhoto, string CaseLocation);
        #endregion

        #region Delete
        List<UserType> DeleteUserType(int UserTypeID);
        List<EnvironmentalConcern> DeleteEnvironmentalConcern(int EnvironmentalConcernID);
        List<UpdatedStatus> DeleteUpdatedStatus(int UpdatedStatusID);
        List<CaseReport> DeleteCaseReport(int CaseReportID);
        #endregion

        #region Update
        List<UserType> UpdateUserType(int UserTypeID, string Description);
        List<EnvironmentalConcern> UpdateEnvironmentalConcern(int EnvironmentalConcernID, string Description);
        List<UpdatedStatus> UpdateUpdatedStatus(int UpdatedStatusID, string Description);
        List<CaseReport> UpdateCaseReport(int CaseReportID, int UpdatedStatusID);
        #endregion

        List<UserInformation> GetUserInformation();

        
    }
}
