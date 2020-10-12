using CoreBaseLib.Models;
using Microsoft.Extensions.Configuration;
using SqlLib2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreBaseLib.Models
{
    public class TrackLogService : ITrackLog
    {
        private readonly IConfiguration _configuration;
        private readonly DbHelper _dbHelper;
        private readonly DapperHelper _dapperHelper;
        public TrackLogService(IConfiguration configuration)
        {
            _configuration = configuration;
            _dapperHelper = new DapperHelper(_configuration);
            _dbHelper = new DbHelper(_configuration);
        }
        public RVal AddtoCartlgAddData(AddtoCartlgModel data)
        {
            var cmdHelper = _dbHelper.GetNpgCmdHelper();
            cmdHelper.TableName = "addtocartlg";
            var cmd = cmdHelper.GetInsertCmd(data);
            var rval = _dbHelper.ExecuteNpgNonQuery(cmd);
            return rval;
        }
        public RVal AddPaymentInfolgAddData(AddPaymentInfolgModel data)
        {
            var cmdHelper = _dbHelper.GetNpgCmdHelper();
            cmdHelper.TableName = "addpaymentinfolg";
            var cmd = cmdHelper.GetInsertCmd(data);
            var rval = _dbHelper.ExecuteNpgNonQuery(cmd);
            return rval;
        }

        public RVal AddToWishlistlgAddData(AddToWishlistlgModel data)
        {
            var cmdHelper = _dbHelper.GetNpgCmdHelper();
            cmdHelper.TableName = "addtowishlistlg";
            var cmd = cmdHelper.GetInsertCmd(data);
            var rval = _dbHelper.ExecuteNpgNonQuery(cmd);
            return rval;
        }

        public RVal CompleteRegistrationlgAddData(CompleteRegistrationlgModel data)
        {
            var cmdHelper = _dbHelper.GetNpgCmdHelper();
            cmdHelper.TableName = "completeregistrationlg";
            var cmd = cmdHelper.GetInsertCmd(data);
            var rval = _dbHelper.ExecuteNpgNonQuery(cmd);
            return rval;
        }

        public RVal InitiateCheckoutlgAddData(InitiateCheckoutlgModel data)
        {
            var cmdHelper = _dbHelper.GetNpgCmdHelper();
            cmdHelper.TableName = "initiatecheckoutlg";
            var cmd = cmdHelper.GetInsertCmd(data);
            var rval = _dbHelper.ExecuteNpgNonQuery(cmd);
            return rval;
        }

        public RVal PageViewlgAddData(PageViewlgModel data)
        {
            var cmdHelper = _dbHelper.GetNpgCmdHelper();
            cmdHelper.TableName = "pageviewlg";
            var cmd = cmdHelper.GetInsertCmd(data);
            var rval = _dbHelper.ExecuteNpgNonQuery(cmd);
            return rval;
        }

        public RVal PurchaselgAddData(PurchaselgModel data)
        {
            var cmdHelper = _dbHelper.GetNpgCmdHelper();
            cmdHelper.TableName = "purchaselg";
            var cmd = cmdHelper.GetInsertCmd(data);
            var rval = _dbHelper.ExecuteNpgNonQuery(cmd);
            return rval;
        }


        public RVal SearchlgAddData(SearchlgModel data)
        {
            var cmdHelper = _dbHelper.GetNpgCmdHelper();
            cmdHelper.TableName = "searchlg";
            var cmd = cmdHelper.GetInsertCmd(data);
            var rval = _dbHelper.ExecuteNpgNonQuery(cmd);
            return rval;
        }

        public RVal SubscribelgAddData(SubscribelgModel data)
        {
            var cmdHelper = _dbHelper.GetNpgCmdHelper();
            cmdHelper.TableName = "subscribelg";
            var cmd = cmdHelper.GetInsertCmd(data);
            var rval = _dbHelper.ExecuteNpgNonQuery(cmd);
            return rval;
        }

    }
}
