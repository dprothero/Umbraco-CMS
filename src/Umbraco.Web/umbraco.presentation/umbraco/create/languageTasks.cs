using System;
using System.Data;

using System.Web.Security;
using umbraco.BusinessLogic;
using umbraco.DataLayer;
using umbraco.BasePages;
using umbraco.IO;
using umbraco.cms.businesslogic.member;

namespace umbraco
{
    public class languageTasks : interfaces.ITask
    {

        private string _alias;
        private int _parentID;
        private int _typeID;
        private int _userID;

        public int UserId
        {
            set { _userID = value; }
        }
        public int TypeID
        {
            set { _typeID = value; }
            get { return _typeID; }
        }


        public string Alias
        {
            set { _alias = value; }
            get { return _alias; }
        }

        public int ParentID
        {
            set { _parentID = value; }
            get { return _parentID; }
        }

        public bool Save()
        {
            cms.businesslogic.language.Language.MakeNew(Alias);
            return true;
        }

        public bool Delete()
        {
            new cms.businesslogic.language.Language(ParentID).Delete();
            return false;
        }

        public languageTasks()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }

}
