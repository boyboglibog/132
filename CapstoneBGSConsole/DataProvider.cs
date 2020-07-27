using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneBGSConsole
{
    using Dapper;
    using System.Data;
    using System.Data.SqlClient;

    public class DataProvider : DataAccess, IDataProvider
    {
        #region View
        public List<UserType> GetUserType()
        {
            var result = new List<UserType>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                result = con.Query<UserType>(
                    StoredProcedureEnum.V_UserType.ToString(), commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }

        public List<EnvironmentalConcern> GetEnvironmentalConcern()
        {
            var result = new List<EnvironmentalConcern>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                result = con.Query<EnvironmentalConcern>(
                    StoredProcedureEnum.V_EnvironmentalConcern.ToString(), commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }

        public List<UpdatedStatus> GetUpdatedStatus()
        {
            var result = new List<UpdatedStatus>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                result = con.Query<UpdatedStatus>(
                    StoredProcedureEnum.V_UpdatedStatus.ToString(), commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }


        public List<CaseReport> GetCaseReport()
        {
            var result = new List<CaseReport>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                result = con.Query<CaseReport>(
                    StoredProcedureEnum.V_CaseReport.ToString(), commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }


        public List<UserInformation> GetUserInformation()
        {
            var result = new List<UserInformation>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                result = con.Query<UserInformation>(
                    StoredProcedureEnum.V_UserInformation.ToString(), commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }


        #endregion

        #region Insert
        public List<UserType> InsertUserType(int UserTypeID, string Description)
        {
            var result = new List<UserType>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@UserTypeID", UserTypeID);
                param.Add("@Description", Description);

                result = con.Query<UserType>(
                    StoredProcedureEnum.I_UserType.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }

        public List<EnvironmentalConcern> InsertEnvironmentalConcern(int EnvironmentalConcernID, string Description)
        {
            var result = new List<EnvironmentalConcern>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@EnvironmentalConcernID", EnvironmentalConcernID);
                param.Add("@Description", Description);

                result = con.Query<EnvironmentalConcern>(
                    StoredProcedureEnum.I_EnvironmentalConcern.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }

        public List<UpdatedStatus> InsertUpdatedStatus(int UpdatedStatusID, string Description)
        {
            var result = new List<UpdatedStatus>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@UpdatedStatusID", UpdatedStatusID);
                param.Add("@Description", Description);

                result = con.Query<UpdatedStatus>(
                    StoredProcedureEnum.I_UpdatedStatus.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }

        public List<CaseReport> InsertCaseReport(int UserInformationID, int EnvironmentalConcernID, int XCoordinates, int YCoordinates, string CaseReportPhoto, string CaseLocation)
        {
            var result = new List<CaseReport>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@UserInformationID", UserInformationID);
                param.Add("@EnvironmentalConcernID", EnvironmentalConcernID);
                param.Add("@XCoordinates", XCoordinates);
                param.Add("@YCoordinates", YCoordinates);
                param.Add("@CaseReportPhoto", CaseReportPhoto);
                param.Add("@CaseLocation", CaseLocation);

                result = con.Query<CaseReport>(
                    StoredProcedureEnum.I_CaseReport.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        #endregion


        #region Delete
        public List<UserType> DeleteUserType(int UserTypeID)
        {
            var result = new List<UserType>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@UserTypeID", UserTypeID);

                result = con.Query<UserType>(
                    StoredProcedureEnum.D_UserType.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }

        public List<EnvironmentalConcern> DeleteEnvironmentalConcern(int EnvironmentalConcernID)
        {
            var result = new List<EnvironmentalConcern>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@EnvironmentalConcernID", EnvironmentalConcernID);

                result = con.Query<EnvironmentalConcern>(
                    StoredProcedureEnum.D_EnvironmentalConcern.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }

        public List<UpdatedStatus> DeleteUpdatedStatus(int UpdatedStatusID)
        {
            var result = new List<UpdatedStatus>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@UpdatedStatusID", UpdatedStatusID);

                result = con.Query<UpdatedStatus>(
                    StoredProcedureEnum.D_UpdatedStatus.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }

        public List<CaseReport> DeleteCaseReport(int CaseReportID)
        {
            var result = new List<CaseReport>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@CaseReportID", CaseReportID);

                result = con.Query<CaseReport>(
                    StoredProcedureEnum.D_CaseReport.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        #endregion

        #region Update
        public List<UserType> UpdateUserType(int UserTypeID, string Description)
        {
            var result = new List<UserType>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@UserTypeID", UserTypeID);
                param.Add("@Description", Description);

                result = con.Query<UserType>(
                    StoredProcedureEnum.U_UserType.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }

        public List<EnvironmentalConcern> UpdateEnvironmentalConcern(int EnvironmentalConcernID, string Description)
        {
            var result = new List<EnvironmentalConcern>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@EnvironmentalConcernID", EnvironmentalConcernID);
                param.Add("@Description", Description);

                result = con.Query<EnvironmentalConcern>(
                    StoredProcedureEnum.U_EnvironmentalConcern.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        public List<UpdatedStatus> UpdateUpdatedStatus(int UpdatedStatusID, string Description)
        {
            var result = new List<UpdatedStatus>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@UpdatedStatusID", UpdatedStatusID);
                param.Add("@Description", Description);

                result = con.Query<UpdatedStatus>(
                    StoredProcedureEnum.U_UpdatedStatus.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }

        public List<CaseReport> UpdateCaseReport(int CaseReportID, int UpdatedStatusID)
        {
            var result = new List<CaseReport>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@CaseReportID", CaseReportID);
                param.Add("@UpdatedStatusID", UpdatedStatusID);

                result = con.Query<CaseReport>(
                    StoredProcedureEnum.U_CaseReport.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        #endregion

    }
}