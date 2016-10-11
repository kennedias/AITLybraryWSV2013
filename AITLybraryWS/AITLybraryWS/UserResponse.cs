using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLogic;
using System.Data;
using System.ComponentModel;

namespace AITLybraryWS
{
    [Serializable]
    public class UserResponse
    {
        # region fields

        private int _userID;
        private string _userName;
        private int _userLevelCode;
        private string _userLevelDescription;

        #endregion

        # region properties

        public int ID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        public string Name
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public int LevelCode
        {
            get { return _userLevelCode; }
            set { _userLevelCode = value; }
        }

        public string LevelDescription
        {
            get { return _userLevelDescription; }
            set { _userLevelDescription = value; }
        }

        #endregion


        #region methods


        

        #endregion
    }
}