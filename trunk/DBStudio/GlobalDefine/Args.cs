//=============================================================================
//    DBStudio
//    Copyright (C) 2006  ms44

//    This library is free software; you can redistribute it and/or
//    modify it under the terms of the GNU General Public
//    License as published by the Free Software Foundation; either
//    version 2 of the License, or (at your option) any later version.

//    This library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.

//    You should have received a copy of the GNU Lesser General Public
//    License along with this library; if not, write to the Free Software
//    Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

//    If you have any questions ,please contact me via 54715112@qq.com
//===============================================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using DBStudio.CommandFactory;

namespace DBStudio.GlobalDefine
{
    /// <summary>
    /// For Execute Sql Command in RibbionIDE.cs
    /// </summary>
    public class ExecuteArgs
    {
        public ICmd CurrentCommand { get; set; }
        public string CommandString { get; set; }
    }

    public enum UsingOleDbType
    {
        Excel,
        Access,
        CSV,
    }

    /// <summary>
    /// For Get All Database Type Collection using 
    /// Ex : in NewEntry,MainEntry,NewPortal window
    /// </summary>
    public class NewDbCollection
    {
        public ImageSource LogoImage { get; set; }
        public string Comment { get; set; }
        public string NewURL { get; set; }
        public string ToolTipText { get; set; }
        public string OfficalLink { get; set; }
    }

    internal class NotifySqlCmdArgs : System.EventArgs
    {
        public bool IsExecuteCommand { get; set; }

    }

    /// <summary>
    /// 数据库同步操作结果对象
    /// 用于显示给用户的友好信息
    /// </summary>
    internal class SyncResultArgs
    {
        public string TableName { get; set; }
        public bool ProcessStatus { get; set; }
        public string LastErrorMsg { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    internal enum SchemaArgsCollection
    {
        Yes,
        No,
    };

    internal class CreateTableSchemaArgs
    {
        internal SchemaArgsCollection option { get; set; }

        internal string DisplayName { get; set; }
        public override string ToString()
        {
            return DisplayName;
        }
    }

    /// <summary>
    /// Vital
    /// </summary>
    internal enum TreeItemType
    {
        Database,
        Table,
        Column,
        Index,
        View,
        ViewParent,
        ColumnParentNode,
        IndexParentNode,
        StoredProcedure,
        StoredProcedureParentNode,
        //系统视图总节点
        SystemViewNode,
        //系统视图下的每个SCHEMA节点
        SystemView_SchemaNode,
        //系统视图下的每个SCHEMA的所属列的节点
        SystemView_Schema_ColumnNode,
        NotDefined,
        //
        Triggers,
        TriggersParent,
    }

    /// <summary>
    /// Vital Object
    /// Stored in each TreeView element tag
    /// </summary>
    public class TreeItemArgs
    {
        internal string DataBaseName { get; set; }

        internal string IndexName { get; set; }

        internal string TableName { get; set; }

        internal string ColumnName { get; set; }

        internal TreeItemType ItemType { get; set; }

        internal string StoredProcedureName { get; set; }

        internal string ViewName { get; set; }

        /// <summary>
        /// System View(like ssce has)
        /// </summary>
        internal string SystemViewName { get; set; }

        internal string TriggerName { get; set; }
    }

    [Serializable()]
    internal class DbHistoryList
    {
        internal List<string> DbHistoryFullPathList { get; set; }
    }

}
